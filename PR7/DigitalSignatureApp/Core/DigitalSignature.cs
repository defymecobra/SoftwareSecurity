using System;
using System.Security.Cryptography;
using System.Text;

namespace DigitalSignatureApp.Core
{
    public class DigitalSignature
    {
        private RSACryptoServiceProvider _rsa;

        public DigitalSignature()
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

        public string SignMessage(string message, string privateKeyXml)
        {
            using (var rsaSign = new RSACryptoServiceProvider())
            using (var sha1 = new SHA1CryptoServiceProvider())
            {
                rsaSign.FromXmlString(privateKeyXml);
                byte[] messageBytes = Encoding.UTF8.GetBytes(message);
                byte[] hash = sha1.ComputeHash(messageBytes);
                byte[] signature = rsaSign.SignHash(hash, CryptoConfig.MapNameToOID("SHA1"));
                return BitConverter.ToString(signature).Replace("-", "");
            }
        }

        public bool VerifySignature(string message, string signatureHex, string publicKeyXml)
        {
            try
            {
                using (var rsaVerify = new RSACryptoServiceProvider())
                using (var sha1 = new SHA1CryptoServiceProvider())
                {
                    rsaVerify.FromXmlString(publicKeyXml);
                    byte[] messageBytes = Encoding.UTF8.GetBytes(message);
                    byte[] hash = sha1.ComputeHash(messageBytes);
                    byte[] signature = HexToBytes(signatureHex);
                    return rsaVerify.VerifyHash(hash, CryptoConfig.MapNameToOID("SHA1"), signature);
                }
            }
            catch
            {
                return false;
            }
        }

        private byte[] HexToBytes(string hex)
        {
            hex = hex.Replace(" ", "").Replace("-", "");
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return bytes;
        }
    }
}
