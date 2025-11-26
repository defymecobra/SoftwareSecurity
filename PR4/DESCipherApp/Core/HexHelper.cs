using System;
using System.Text;

namespace DESCipherApp.Core
{
    public static class HexHelper
    {
        public static string BytesToHex(byte[] data)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in data)
            {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }

        public static byte[] HexToBytes(string hex)
        {
            // Remove any spaces or dashes
            hex = hex.Replace(" ", "").Replace("-", "");
            
            if (hex.Length % 2 != 0)
                throw new ArgumentException("Hex string must have an even number of characters.");

            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return bytes;
        }
    }
}
