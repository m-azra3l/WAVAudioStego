using System.Security.Cryptography;
using System.Xml;

namespace WAVAudioStego
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        int maxTextLength;
        byte[]? audioData;
        string? xmlfilePath;
        string? textData;
        byte[]? encryptedText;
        byte[]? encodedAudioData;

        private void btnUploadAudioEncode_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Wave Audio Files (*.wav)|*.wav";
            dialog.Title = "Select a Wave Audio File";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtAudioPathEncode.Text = dialog.FileName;
            }
            else
            {
                txtAudioPathEncode.Text = "";
                return;
            }
            
            audioData = File.ReadAllBytes(txtAudioPathEncode.Text);

            if (!Helper.IsValidWavFile(audioData))
            {
                MessageBox.Show("Invalid .wav file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtAudioPathEncode.Text = "";
                return;
            }
            // Calculate the maximum length of a text message that can be encoded into the selected WAV audio file
            int headerOffset = Helper.GetWavDataOffset(audioData);
            int availableBytes = audioData.Length - headerOffset;
            maxTextLength = (availableBytes - 32) / 8;

            // Display the maximum length of a text message that can be encoded into the selected WAV audio file in a label
            lblMaxTextLength.Text = $"Max available text length: {maxTextLength} characters";
        }

        private void btnUploadPublicKeyEncode_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Public Key (.xml)|*.xml";
            dialog.Title = "Select a Public Key";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtPublicKeyEncode.Text = dialog.FileName;
            }
            else
            {
                txtPublicKeyEncode.Text = "";
                return;
            }
            xmlfilePath = txtPublicKeyEncode.Text;

            if (!Helper.IsValidXmlFile(xmlfilePath))
            {
                MessageBox.Show("Invalid .xml file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPublicKeyEncode.Text = "";
                return;
            }

            RSAParameters publicKey;
            try
            {
                publicKey = Helper.ReadPublicKeyFromXmlFile(xmlfilePath);
                btnUploadTextFileEncode.Enabled = true;
            }
            catch (Exception ex)
            {
                // Handle the exception here
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPublicKeyEncode.Text = "";
                return;
            }
        }

        private async void btnUploadTextFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files (.txt)|*.txt";
            dialog.Title = "Select a Text File";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtTextFilePathEncode.Text = dialog.FileName;
            }
            else
            {
                txtTextFilePathEncode.Text = "";
                return;
            }
            string filePath = txtTextFilePathEncode.Text;

            if (!Helper.IsValidTxtFile(filePath))
            {
                MessageBox.Show("Invalid .txt file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTextFilePathEncode.Text = "";
                return;
            }
            // Read the contents of the selected text file and calculate length after encryption
            textData = File.ReadAllText(txtTextFilePathEncode.Text);
            RSAParameters publicKey = Helper.ReadPublicKeyFromXmlFile(txtPublicKeyEncode.Text);            

            encryptedText = await Helper.EncryptMessage(textData, publicKey);
            int textLength = encryptedText.Length;

            // Display the length of the selected text file in a label
            lblTextLength.Text = $"Encrypted text length: {textLength} characters";

            // Compare the length of the selected text file with the maximum length of a text message that can be encoded into the selected WAV audio file
            if (textLength > maxTextLength)
            {
                lblWarning.ForeColor = Color.Red;
                lblWarning.Text = "Warning: text is too long";
                return;
            }
            else
            {
                btnEncode.Enabled = true;
                lblWarning.ForeColor = Color.Black;
                lblWarning.Text = "";
            }
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            progressEncode.Value = 0;
            btnEncode.Enabled = false;
            progressEncode.Value = 25;

            byte[]? encodedAudioData = Helper.EncodeAudio(audioData, encryptedText);
            progressEncode.Value = 50;

            if (encodedAudioData != null)
            {
                progressEncode.Value = 75;
                SaveFileDialog dialog = new();
                dialog.Filter = "Wave Audio Files (*.wav)|*.wav";
                dialog.Title = "Select a Wave Audio File";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(dialog.FileName, encodedAudioData);
                    progressEncode.Value = 100;
                    MessageBox.Show("Data embedded and saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtAudioPathEncode.Text = "";
                    txtTextFilePathEncode.Text = "";
                    txtPublicKeyEncode.Text = "";
                    progressEncode.Value = 0;
                    return;
                }                
            }
            else
            {
                progressDecode.Value = 0;
                MessageBox.Show("Embedding failed.\n The message might be too large for the audio file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            progressEncode.Value = 0;
        }

        private void btnUploadAudioDecode_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Wave Audio Files (*.wav)|*.wav";
            dialog.Title = "Select a Wave Audio File";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtAudioPathDecode.Text = dialog.FileName;
            }
            else
            {
                txtAudioPathDecode.Text = "";
                return;
            }
            encodedAudioData = File.ReadAllBytes(txtAudioPathDecode.Text);

            if (!Helper.IsValidWavFile(encodedAudioData))
            {
                MessageBox.Show("Invalid .wav file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtAudioPathDecode.Text = "";
                return;
            }
        }

        private void btnUploadPrivateKeyDecode_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Private Key (.xml)|*.xml";
            dialog.Title = "Select a Private Key";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtPrivateKeyDecode.Text = dialog.FileName;
            }
            else
            {
                txtPrivateKeyDecode.Text = "";
                return;
            }
            string xmlfilePath = txtPrivateKeyDecode.Text;

            if (!Helper.IsValidXmlFile(xmlfilePath))
            {
                MessageBox.Show("Invalid .xml file!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPrivateKeyDecode.Text = "";
                return;
            }

            RSAParameters privateKey;
            try
            {
                privateKey = Helper.ReadPrivateKeyFromXmlFile(txtPrivateKeyDecode.Text);
                btnDecode.Enabled = true;
            }
            catch (Exception ex)
            {
                // Handle the exception here
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPrivateKeyDecode.Text = "";
                btnDecode.Enabled = false;
                return;
            }
        }

        private async void btnDecode_Click(object sender, EventArgs e)
        {
            progressDecode.Value = 0;
            btnDecode.Enabled = false;

            RSAParameters privateKey = Helper.ReadPrivateKeyFromXmlFile(txtPrivateKeyDecode.Text);

            byte[]? decodedTextFromAudio = Helper.DecodeAudio(encodedAudioData);
            progressDecode.Value = 25;

            var (decryptedText, errorMessage) = await Helper.DecryptMessage(decodedTextFromAudio, privateKey);
            progressDecode.Value = 50;
            if (errorMessage != null)
            {
                // Handle error
                MessageBox.Show(errorMessage,"Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPrivateKeyDecode.Text = "";
                progressDecode.Value = 0;
                return;
            }

            if (decryptedText != null)
            {
                progressDecode.Value = 75;
                SaveFileDialog dialog = new();
                dialog.Filter = "Text Files (.txt)|*.txt";
                dialog.Title = "Select a Text File";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, decryptedText);
                    progressDecode.Value = 100;
                    MessageBox.Show("File extracted and saved successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtAudioPathDecode.Text = "";
                    txtPrivateKeyDecode.Text = "";
                    progressDecode.Value = 0;
                    return;
                }               
            }
            else
            {
                MessageBox.Show("Extraction failed!\n There might be something wrong with the audio file!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            progressDecode.Value = 0;
        }

        private void generateKeys_Click(object sender, EventArgs e)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                progressBar.Value = 25;

                var publicKey = rsa.ToXmlString(false);
                var privateKey = rsa.ToXmlString(true);

                progressBar.Value = 50;

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                saveFileDialog.Title = "Save pair keys";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    progressBar.Value = 75;

                    var publicKeyXml = new XmlDocument();
                    publicKeyXml.LoadXml(publicKey);
                    publicKeyXml.Save(saveFileDialog.FileName + "_public_key.xml");

                    var privateKeyXml = new XmlDocument();
                    privateKeyXml.LoadXml(privateKey);
                    privateKeyXml.Save(saveFileDialog.FileName + "_private_key.xml");
                    progressBar.Value = 100;
                    MessageBox.Show("Generated pair keys successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    progressBar.Value = 0;
                    return;
                }

            }
        }
    }
}