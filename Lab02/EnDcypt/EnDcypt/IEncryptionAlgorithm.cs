﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnDcypt
{
    internal interface IEncryptionAlgorithm
    {
        string Encrypt(string plainText);
        string Decrypt(string encryptedText);

    }
}
