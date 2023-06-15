using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace WAVAudioStego
{
    public static class Helper
    {
        public static async Task<byte[]> EncryptMessage(string message, RSAParameters publickey)
        {
            using Aes aes = Aes.Create();
            using RSACryptoServiceProvider rsa = new();
            byte[] encryptedData;
            using MemoryStream output = new();
            using CryptoStream cryptoStream = new(output, aes.CreateEncryptor(), CryptoStreamMode.Write);
            await cryptoStream.WriteAsync(Encoding.Unicode.GetBytes(message));
            await cryptoStream.FlushFinalBlockAsync();
            encryptedData = output.ToArray();

            rsa.ImportParameters(publickey);
            byte[] encryptedKey = rsa.Encrypt(aes.Key, RSAEncryptionPadding.Pkcs1);
            byte[] encryptedIV = rsa.Encrypt(aes.IV, RSAEncryptionPadding.Pkcs1);

            byte[] result = new byte[encryptedKey.Length + encryptedIV.Length + encryptedData.Length];
            Buffer.BlockCopy(encryptedKey, 0, result, 0, encryptedKey.Length);
            Buffer.BlockCopy(encryptedIV, 0, result, encryptedKey.Length, encryptedIV.Length);
            Buffer.BlockCopy(encryptedData, 0, result, encryptedKey.Length + encryptedIV.Length, encryptedData.Length);

            return result;
        }

        public static async Task<(string, string)> DecryptMessage(byte[] encryptedMessage, RSAParameters privateKey)
        {
            try
            {
                using RSACryptoServiceProvider rsa = new();
                rsa.ImportParameters(privateKey);

                int keySize = rsa.KeySize / 8;
                byte[] encryptedKey = new byte[keySize];
                byte[] encryptedIV = new byte[keySize];
                byte[] encryptedData = new byte[encryptedMessage.Length - 2 * keySize];

                Buffer.BlockCopy(encryptedMessage, 0, encryptedKey, 0, keySize);
                Buffer.BlockCopy(encryptedMessage, keySize, encryptedIV, 0, keySize);
                Buffer.BlockCopy(encryptedMessage, 2 * keySize, encryptedData, 0, encryptedData.Length);

                byte[] decryptedKey = rsa.Decrypt(encryptedKey, RSAEncryptionPadding.Pkcs1);
                byte[] decryptedIV = rsa.Decrypt(encryptedIV, RSAEncryptionPadding.Pkcs1);

                using Aes aes = Aes.Create();
                aes.Key = decryptedKey;
                aes.IV = decryptedIV;

                byte[] decryptedData;
                using MemoryStream output = new();
                using CryptoStream cryptoStream = new(output, aes.CreateDecryptor(), CryptoStreamMode.Write);
                await cryptoStream.WriteAsync(encryptedData);
                await cryptoStream.FlushFinalBlockAsync();
                decryptedData = output.ToArray();

                return (Encoding.Unicode.GetString(decryptedData), null);
            }
            catch (CryptographicException)
            {
                return (null, "Incorrect private key.\n Please select correct private key file.");
            }
        }

        public static RSAParameters ReadPublicKeyFromXmlFile(string filePath)
        {
            using RSA rsa = RSA.Create();
            try
            {
                rsa.FromXmlString(File.ReadAllText(filePath));
            }
            catch (CryptographicException)
            {
                throw new Exception("Invalid key! \n Please generate valid keys!!!");
            }
            return rsa.ExportParameters(false);
        }

        public static RSAParameters ReadPrivateKeyFromXmlFile(string filePath)
        {
            using RSA rsa = RSA.Create();
            try
            {
                rsa.FromXmlString(File.ReadAllText(filePath));
            }
            catch (CryptographicException)
            {
                throw new Exception("Invalid key! \n Please select valid key!!!");
            }
            return rsa.ExportParameters(true);
        }

        public static byte[]? EncodeAudio(byte[] audioData, byte[] textData)
        {
            int headerOffset = GetWavDataOffset(audioData);
            if (headerOffset == -1)
            {
                return null;
            }

            int availableBytes = audioData.Length - headerOffset;
            if (textData.Length * 8 + 32 > availableBytes)
            {
                return null;
            }

            byte[] encodedWavData = new byte[audioData.Length];
            Array.Copy(audioData, encodedWavData, audioData.Length);

            for (int i = 0; i < 32; i++)
            {
                byte bit = (byte)((textData.Length >> i) & 1);
                int index = headerOffset + i;
                encodedWavData[index] = (byte)((encodedWavData[index] & 0xFE) | bit);
            }

            for (int i = 0; i < textData.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    byte bit = (byte)((textData[i] >> j) & 1);
                    int index = headerOffset + 32 + i * 8 + j;
                    encodedWavData[index] = (byte)((encodedWavData[index] & 0xFE) | bit);
                }
            }
            return encodedWavData;
        }

        public static byte[]? DecodeAudio(byte[] encodedAudioData)
        {
            int headerOffset = GetWavDataOffset(encodedAudioData);
            if (headerOffset == -1)
            {
                return null;
            }

            int textDataLength = 0;
            for (int i = 0; i < 32; i++)
            {
                int index = headerOffset + i;
                byte bit = (byte)(encodedAudioData[index] & 1);
                textDataLength |= (bit << i);
            }

            if (textDataLength < 0 || textDataLength * 8 + 32 > encodedAudioData.Length - headerOffset)
            {
                return null;
            }

            byte[] decodedTextData = new byte[textDataLength];

            for (int i = 0; i < textDataLength; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int index = headerOffset + 32 + i * 8 + j;
                    byte bit = (byte)(encodedAudioData[index] & 1);
                    decodedTextData[i] |= (byte)(bit << j);
                }
            }            
            return decodedTextData;
        }

        public static bool IsValidWavFile(byte[] audioData)
        {
            if (audioData.Length < 12)
            {
                return false;
            }

            string fileType = Encoding.ASCII.GetString(audioData, 0, 4);
            string format = Encoding.ASCII.GetString(audioData, 8, 4);

            return fileType == "RIFF" && format == "WAVE";
        }

        public static bool IsValidXmlFile(string filePath)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);
                return true;
            }
            catch (XmlException)
            {
                return false;
            }
        }

        public static bool IsValidTxtFile(string filePath)
        {
            return File.Exists(filePath) && Path.GetExtension(filePath) == ".txt";
        }

        public static int GetWavDataOffset(byte[] audioData)
        {
            const int RiffHeaderSize = 12;
            int offset = RiffHeaderSize;

            while (offset < audioData.Length - 8)
            {
                string chunkID = Encoding.ASCII.GetString(audioData, offset, 4);
                int chunkSize = BitConverter.ToInt32(audioData, offset + 4);

                if (chunkID == "data")
                {
                    return offset + 8;
                }

                offset += 8 + chunkSize;
            }

            return -1;
        }
    }
}
