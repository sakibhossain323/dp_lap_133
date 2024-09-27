// See https://aka.ms/new-console-template for more information

using EnDcypt;


// D:\Coding\LabTasks\SWE4502\Lab02
string inputFilePath = "D:\\Coding\\LabTasks\\SWE4502\\Lab02\\input.txt";
string outputFilePath = "D:\\Coding\\LabTasks\\SWE4502\\Lab02\\output.txt";
string revertedOutputFilePath = "D:\\Coding\\LabTasks\\SWE4502\\Lab02\\revertedOutput.txt";

IEncryptionAlgorithm cipher = new CeaserCipher(4);
FileEncryptor cipherEncryptor = new FileEncryptor(cipher);
cipherEncryptor.EncryptFile(inputFilePath, outputFilePath);
cipherEncryptor.DecryptFile(outputFilePath, revertedOutputFilePath);

//IEncryptionAlgorithm aes = new AdvancedEncryptionStandard();
//FileEncryptor aesEncryptor = new FileEncryptor(aes);
//aesEncryptor.EncryptFile(inputFilePath, outputFilePath);
//aesEncryptor.DecryptFile(outputFilePath, revertedOutputFilePath);

//IEncryptionAlgorithm des = new DataEncryptionStandard();
//FileEncryptor desEncryptor = new FileEncryptor(des);
//desEncryptor.EncryptFile(inputFilePath, outputFilePath);