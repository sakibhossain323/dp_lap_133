using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace EnDcypt
{
    internal class DataEncryptionStandard: IEncryptionAlgorithm
    {
        private byte[] key;
        private byte[] iv;

        public DataEncryptionStandard()
        {
            key = Encoding.UTF8.GetBytes("1234567890123456");
            iv = Encoding.UTF8.GetBytes("12345678");
        }

        public string Decrypt(string encryptedText)
        {
            using(TripleDES des = TripleDES.Create())
            {
                des.Key = key;
                des.IV = iv;
                ICryptoTransform decryptor = des.CreateDecryptor(des.Key, des.IV);
                byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
                byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }

        public string Encrypt(string plainText)
        {
            using(TripleDES des = TripleDES.Create())
            {
                des.Key = key;
                des.IV = iv;
                ICryptoTransform encryptor = des.CreateEncryptor(des.Key, des.IV);
                byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                byte[] encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
                return Convert.ToBase64String(encryptedBytes);
            }
        }
    }
}
