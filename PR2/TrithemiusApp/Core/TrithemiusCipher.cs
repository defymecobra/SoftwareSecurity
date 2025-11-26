using System;
using System.Text;

namespace TrithemiusApp.Core
{
    public enum KeyType
    {
        Linear,
        NonLinear,
        Motto
    }

    public static class TrithemiusCipher
    {
        private const string AlphabetEng = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string AlphabetUkr = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";

        public static string Encrypt(string text, KeyType type, object[] keyParams, string language)
        {
            string alphabet = language == "UKR" ? AlphabetUkr : AlphabetEng;
            return ProcessText(text, type, keyParams, alphabet, true);
        }

        public static string Decrypt(string text, KeyType type, object[] keyParams, string language)
        {
            string alphabet = language == "UKR" ? AlphabetUkr : AlphabetEng;
            return ProcessText(text, type, keyParams, alphabet, false);
        }

        private static string ProcessText(string text, KeyType type, object[] keyParams, string alphabet, bool encrypt)
        {
            int n = alphabet.Length;
            StringBuilder result = new StringBuilder();
            int p = 0; // Position of the character in the text (only counting valid alphabet chars)

            foreach (char c in text)
            {
                bool isUpper = char.IsUpper(c);
                char target = char.ToUpper(c);
                int index = alphabet.IndexOf(target);

                if (index != -1)
                {
                    int k = GetShift(type, keyParams, p, alphabet);
                    
                    int newIndex;
                    if (encrypt)
                    {
                        newIndex = (index + k) % n;
                    }
                    else
                    {
                        newIndex = (index - k) % n;
                    }

                    if (newIndex < 0) newIndex += n;
                    
                    char newChar = alphabet[newIndex];
                    result.Append(isUpper ? newChar : char.ToLower(newChar));
                    p++; // Increment position only for valid characters
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        private static int GetShift(KeyType type, object[] keyParams, int p, string alphabet)
        {
            int k = 0;
            switch (type)
            {
                case KeyType.Linear:
                    // k = A*p + B
                    int A = Convert.ToInt32(keyParams[0]);
                    int B = Convert.ToInt32(keyParams[1]);
                    k = A * p + B;
                    break;
                case KeyType.NonLinear:
                    // k = A*p^2 + B*p + C
                    int A2 = Convert.ToInt32(keyParams[0]);
                    int B2 = Convert.ToInt32(keyParams[1]);
                    int C2 = Convert.ToInt32(keyParams[2]);
                    k = A2 * p * p + B2 * p + C2;
                    break;
                case KeyType.Motto:
                    // k = IndexOf(Motto[p % Motto.Length])
                    string motto = keyParams[0].ToString().ToUpper();
                    if (string.IsNullOrEmpty(motto)) return 0;
                    char mottoChar = motto[p % motto.Length];
                    k = alphabet.IndexOf(mottoChar);
                    if (k == -1) k = 0; // Fallback if motto char not in alphabet
                    break;
            }
            return k;
        }
    }
}
