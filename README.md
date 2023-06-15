# WAVAudioStego

 WAVAudioStego is a .NET 7 desktop application designed for audio steganography, which is the art of hiding secret information within an audio file. With this application, users can hide text messages in form of text files within audio audio files and extract them later using a private key.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Code Overview](#code overview)
- [Conclusion](#conclusion)
- [License](#license)

## Installation

To use this application, you need to have .NET 7 installed on your machine.

1. Clone the repository:

   ```shell
   git clone https://github.com/m-azra3l/WAVAudioStego.git
   ```

2. Build the project:

   ```shell
   dotnet build
   ```

## Usage

1. Launch the application.

    ```shell
    dotnet run
    ```

2. Generate a pair of RSA keys:
   - Click on the "Generate Keys" button, this will open a file dialog to save the public and private keys.
   - The keys will be saved as XML files.

3. Encoding:
   - Click on the "Upload Audio" button to select a WAV audio file.
   - The selected audio file will be validated, and if valid, its details will be displayed.
   - Click on the "Upload Public Key" button to select the public key XML file.
   - The selected public key file will be validated, and if valid, the encryption process can proceed.
   - Click on the "Upload Text File" button to select a text file to be encoded.
   - The selected text file will be validated, and if valid, its contents will be encrypted using the public key.
   - The length of the encrypted text will be displayed.
   - Click on the "Encode" button to encode the encrypted text into the audio file.
   - The progress of the encoding process will be displayed.

4. Decoding:
   - Click on the "Upload Audio" button to select a WAV audio file containing encoded text.
   - The selected audio file will be validated, and if valid, the decoding process can proceed.
   - Click on the "Upload Private Key" button to select the private key XML file.
   - The selected private key file will be validated, and if valid, the decryption process can proceed.
   - Click on the "Decode" button to decode the text from the audio file.
   - The decrypted text will be displayed, and you will have the option to save it as a text file.

## Code Overview

The project consists of a single form, `Main`, which contains event handlers for the various buttons and progress bars used in the application. The form uses the `Helper` class to perform the steganography and encryption/decryption operations.

The `Helper` class contains static methods for validating WAV audio files and RSA key files, reading key files, encrypting and decrypting messages, and encoding and decoding text messages in WAV audio files.

The code for the project is written in C# and uses the .NET Framework 4.7.2.

## Conclusion

This project demonstrates the use of steganography techniques to hide text messages in a WAV audio file and the use of RSA encryption to secure the hidden message. The project can be used as a starting point for developing more advanced steganography and encryption applications.

## License

This project is licensed under the [MIT License](LICENSE).