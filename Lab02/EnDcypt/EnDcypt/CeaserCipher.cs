using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnDcypt
{
    internal class CeaserCipher : IEncryptionAlgorithm
    {
        private int shiftKey;
        public CeaserCipher(int shiftKey)
        {
            this.shiftKey = shiftKey;
        }
        public string Decrypt(string encryptedText)
        {
            string plainText = "";
            foreach (char c in encryptedText)
            {
                if('a'<= c && c<='z')
                {
                    plainText+= (char)('a' + (c - 'a' + 26 - shiftKey) % 26);
                }
                else if('A'<= c && c<='Z')
                {
                    plainText+= (char)('A' + (c - 'A' + 26 - shiftKey) % 26);
                }
                else
                {
                    plainText+= c;
                }
            }
            return plainText;
        }

        public string Encrypt(string plainText)
        {
            string encryptedText = "";
            foreach (char c in plainText)
            {
                if('a'<= c && c<='z')
                {
                    encryptedText+= (char)('a' + (c - 'a' + shiftKey) % 26);
                }
                else if('A'<= c && c<='Z')
                {
                    encryptedText+= (char)('A' + (c - 'A' + shiftKey) % 26);
                }
                else
                {
                    encryptedText+= c;
                }
               
            }
            return encryptedText;
        }
    }
}
