using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DESCipherApp.Core
{
    public static class DESCipher
    {
        public static string EncryptText(string plainText, byte[] key, byte[] iv)
        {
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                des.Key = key;
                des.IV = iv;
                des.Mode = CipherMode.CBC;
                des.Padding = PaddingMode.PKCS7;

                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    byte[] data = Encoding.UTF8.GetBytes(plainText);
                    cs.Write(data, 0, data.Length);
                    cs.FlushFinalBlock();
                    
                    return HexHelper.BytesToHex(ms.ToArray());
                }
            }
        }

        public static string DecryptText(string cipherTextHex, byte[] key, byte[] iv)
        {
            byte[] cipherBytes = HexHelper.HexToBytes(cipherTextHex);
            
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                des.Key = key;
                des.IV = iv;
                des.Mode = CipherMode.CBC;
                des.Padding = PaddingMode.PKCS7;

                using (MemoryStream ms = new MemoryStream(cipherBytes))
                using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Read))
                using (StreamReader sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }

        public static void EncryptFile(string inputPath, string outputPath, byte[] key, byte[] iv)
        {
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                des.Key = key;
                des.IV = iv;
                des.Mode = CipherMode.CBC;
                des.Padding = PaddingMode.PKCS7;

                using (FileStream fsIn = new FileStream(inputPath, FileMode.Open, FileAccess.Read))
                using (FileStream fsOut = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                using (CryptoStream cs = new CryptoStream(fsOut, des.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    fsIn.CopyTo(cs);
                }
            }
        }

        public static void DecryptFile(string inputPath, string outputPath, byte[] key, byte[] iv)
        {
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                des.Key = key;
                des.IV = iv;
                des.Mode = CipherMode.CBC;
                des.Padding = PaddingMode.PKCS7;

                using (FileStream fsIn = new FileStream(inputPath, FileMode.Open, FileAccess.Read))
                using (FileStream fsOut = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                using (CryptoStream cs = new CryptoStream(fsIn, des.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    cs.CopyTo(fsOut);
                }
            }
        }
    }
}
