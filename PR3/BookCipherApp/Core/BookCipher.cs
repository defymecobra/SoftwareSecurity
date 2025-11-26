using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookCipherApp.Core
{
    public class BookCipher
    {
        private char[,] _grid;
        private int _rows;
        private int _cols;
        private Random _random = new Random();

        public char[,] Grid => _grid;
        public int Rows => _rows;
        public int Cols => _cols;

        public void LoadKey(string keyText, int rows, int cols)
        {
            _rows = rows;
            _cols = cols;
            _grid = new char[rows, cols];

            // Clean key text: remove newlines, maybe keep spaces? 
            // Usually book cipher uses the text as is, or just letters.
            // Let's keep letters and digits and spaces, but maybe flatten newlines.
            string cleanKey = keyText.Replace("\r", "").Replace("\n", " ");
            
            int k = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (k < cleanKey.Length)
                    {
                        _grid[i, j] = cleanKey[k++];
                    }
                    else
                    {
                        _grid[i, j] = ' '; // Fill rest with spaces
                    }
                }
            }
        }

        public string Encrypt(string plainText)
        {
            if (_grid == null) throw new InvalidOperationException("Key not loaded.");

            StringBuilder result = new StringBuilder();
            
            foreach (char c in plainText)
            {
                var coords = FindAllCoordinates(c);
                if (coords.Count > 0)
                {
                    // Pick random coordinate
                    var (row, col) = coords[_random.Next(coords.Count)];
                    // Output format: "Row/Col" (1-based usually looks better for humans, let's use 1-based)
                    result.Append($"{row + 1}/{col + 1}, ");
                }
                else
                {
                    // Character not found in key. 
                    // Option 1: Skip
                    // Option 2: Write as is (but breaks format)
                    // Let's write as [c] to indicate literal
                    result.Append($"[{c}], ");
                }
            }

            // Remove trailing comma
            if (result.Length > 2) result.Length -= 2;
            
            return result.ToString();
        }

        public string Decrypt(string cipherText)
        {
            if (_grid == null) throw new InvalidOperationException("Key not loaded.");

            StringBuilder result = new StringBuilder();
            string[] parts = cipherText.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string part in parts)
            {
                if (part.StartsWith("[") && part.EndsWith("]") && part.Length == 3)
                {
                    result.Append(part[1]);
                    continue;
                }

                string[] coords = part.Split('/');
                if (coords.Length == 2 && 
                    int.TryParse(coords[0], out int row) && 
                    int.TryParse(coords[1], out int col))
                {
                    // Convert back to 0-based
                    int r = row - 1;
                    int c = col - 1;

                    if (r >= 0 && r < _rows && c >= 0 && c < _cols)
                    {
                        result.Append(_grid[r, c]);
                    }
                    else
                    {
                        result.Append('?');
                    }
                }
            }

            return result.ToString();
        }

        private List<(int, int)> FindAllCoordinates(char c)
        {
            var list = new List<(int, int)>();
            // Case-insensitive? Usually ciphers are case-insensitive or strict.
            // Let's be case-insensitive for better usability.
            char target = char.ToUpper(c);

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    if (char.ToUpper(_grid[i, j]) == target)
                    {
                        list.Add((i, j));
                    }
                }
            }
            return list;
        }
    }
}
