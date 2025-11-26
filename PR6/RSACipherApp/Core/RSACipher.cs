using System;
using System.Security.Cryptography;
using System.Text;

namespace RSACipherApp.Core
{
    public class RSACipher
    {
        private RSACryptoServiceProvider _rsa;

        public RSACipher()
        {
            _rsa = new RSACryptoServiceProvider(2048);
        }

        public void GenerateKeys(int keySize = 2048)
        {
            _rsa = new RSACryptoServiceProvider(keySize);
        }

        public string GetPublicKeyXml()
        {
            return _rsa.ToXmlString(false);
        }

        public string GetPrivateKeyXml()
        {
            return _rsa.ToXmlString(true);
        }

        public string Encrypt(string plainText, string publicKeyXml)
        {
            using (var rsaEncrypt = new RSACryptoServiceProvider())
            {
                rsaEncrypt.FromXmlString(publicKeyXml);
                byte[] dataToEncrypt = Encoding.UTF8.GetBytes(plainText);
                // Use OAEP padding (false = PKCS#1 v1.5, true = OAEP). 
                // Task images mention "false" in ToXmlString, but for Encrypt usually OAEP (true) is better.
                // However, standard legacy interop often uses PKCS#1 (false). 
                // Let's use false (PKCS#1) as it's more compatible with basic examples unless specified otherwise.
                byte[] encryptedData = rsaEncrypt.Encrypt(dataToEncrypt, false);
                return Convert.ToBase64String(encryptedData);
            }
        }

        public string Decrypt(string cipherTextBase64, string privateKeyXml)
        {
            using (var rsaDecrypt = new RSACryptoServiceProvider())
            {
                rsaDecrypt.FromXmlString(privateKeyXml);
                byte[] dataToDecrypt = Convert.FromBase64String(cipherTextBase64);
                byte[] decryptedData = rsaDecrypt.Decrypt(dataToDecrypt, false);
                return Encoding.UTF8.GetString(decryptedData);
            }
        }
    }
}
