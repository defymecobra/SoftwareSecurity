using System;
using System.Linq;
using System.Text;

namespace CaesarCipherApp.Core
{
    public static class CaesarCipher
    {
        private const string AlphabetEng = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string AlphabetUkr = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";

        public static string EncryptText(string text, int key, string language)
        {
            string alphabet = language == "UKR" ? AlphabetUkr : AlphabetEng;
            return ProcessText(text, key, alphabet);
        }

        public static string DecryptText(string text, int key, string language)
        {
            string alphabet = language == "UKR" ? AlphabetUkr : AlphabetEng;
            return ProcessText(text, -key, alphabet);
        }

        private static string ProcessText(string text, int key, string alphabet)
        {
            int n = alphabet.Length;
            StringBuilder result = new StringBuilder();

            foreach (char c in text)
            {
                bool isUpper = char.IsUpper(c);
                char target = char.ToUpper(c);
                int index = alphabet.IndexOf(target);

                if (index != -1)
                {
                    int newIndex = (index + key) % n;
                    if (newIndex < 0) newIndex += n;
                    
                    char newChar = alphabet[newIndex];
                    result.Append(isUpper ? newChar : char.ToLower(newChar));
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        public static byte[] EncryptBytes(byte[] data, int key)
        {
            byte[] result = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                result[i] = (byte)((data[i] + key) % 256);
            }
            return result;
        }

        public static byte[] DecryptBytes(byte[] data, int key)
        {
            byte[] result = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                int val = (data[i] - key) % 256;
                if (val < 0) val += 256;
                result[i] = (byte)val;
            }
            return result;
        }
    }
}
