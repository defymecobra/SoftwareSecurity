using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipherApp.Core
{
    public static class BruteForce
    {
        public static List<string> Hack(string encryptedText, string language)
        {
            var results = new List<string>();
            string alphabet = language == "UKR" ? "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ" : "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            
            for (int key = 1; key < alphabet.Length; key++)
            {
                string decrypted = CaesarCipher.DecryptText(encryptedText, key, language);
                // Simple heuristic: just return all variants. 
                // In a real app, we could check against a dictionary or letter frequency.
                results.Add($"Key {key}: {decrypted}");
            }
            return results;
        }
    }
}
