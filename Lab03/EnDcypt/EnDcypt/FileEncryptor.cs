using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnDcypt
{
    internal class FileEncryptor
    {
        IEncryptionAlgorithm encryptionAlgorithm;

        public FileEncryptor(IEncryptionAlgorithm encryptionAlgorithm)
        {
            this.encryptionAlgorithm = encryptionAlgorithm;
        }

        public void EncryptFile(string inputFilePath, string outputFilePath)
        {
            string plainText = System.IO.File.ReadAllText(inputFilePath);
            string encryptedText = encryptionAlgorithm.Encrypt(plainText);      
            System.IO.File.WriteAllText(outputFilePath, encryptedText);
        }

        public void DecryptFile(string inputFilePath, string outputFilePath)
        {
            string encryptedText = System.IO.File.ReadAllText(inputFilePath);
            string plainText = encryptionAlgorithm.Decrypt(encryptedText);
            System.IO.File.WriteAllText(outputFilePath, plainText);
        }
    }
}
