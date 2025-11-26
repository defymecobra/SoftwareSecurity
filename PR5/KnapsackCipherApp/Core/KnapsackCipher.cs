using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace KnapsackCipherApp.Core
{
    public class KnapsackCipher
    {
        private Random _random = new Random();

        // Private Key
        public BigInteger[]? B { get; private set; } // Superincreasing sequence
        public BigInteger m { get; private set; }   // Modulus
        public BigInteger t { get; private set; }   // Multiplier
        public BigInteger tInverse { get; private set; } // Modular inverse of t

        // Public Key
        public BigInteger[]? A { get; private set; } // Normal knapsack sequence

        public int N { get; private set; } // Block size in bits (e.g., 8)

        public void GenerateKeys(int n)
        {
            N = n;
            B = new BigInteger[n];
            BigInteger sum = 0;

            // 1. Generate superincreasing sequence B
            for (int i = 0; i < n; i++)
            {
                // b_i > sum(b_0...b_{i-1})
                // Let's add a random value to sum to make it strictly greater
                BigInteger nextVal = sum + _random.Next(1, 10); 
                B[i] = nextVal;
                sum += nextVal;
            }

            // 2. Choose m > sum(B)
            m = sum + _random.Next(10, 50);

            // 3. Choose t such that GCD(t, m) = 1
            do
            {
                t = _random.Next(2, 100); // Start with small t for readability, or larger?
                // Let's make t roughly m/2 size or just random
                t = m / 2 + _random.Next(1, 100); 
            } while (!MathHelpers.AreCoprime(t, m));

            // 4. Calculate tInverse
            tInverse = MathHelpers.ModularInverse(t, m);

            // 5. Calculate Public Key A
            A = new BigInteger[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = (B[i] * t) % m;
            }
        }

        public BigInteger[] Encrypt(string message)
        {
            if (A == null) throw new InvalidOperationException("Keys not generated.");

            byte[] bytes = Encoding.UTF8.GetBytes(message);
            List<BigInteger> cipherText = new List<BigInteger>();

            // Process each byte (since N=8 usually)
            // If N != 8, we would need bit manipulation logic. 
            // For this assignment, assuming N=8 simplifies things significantly.
            
            if (N == 8)
            {
                foreach (byte b in bytes)
                {
                    BigInteger sum = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        // Check if i-th bit is set
                        // We go from high bit to low bit or low to high?
                        // Usually b_0 corresponds to x_0. Let's say x_0 is LSB.
                        if ((b & (1 << i)) != 0)
                        {
                            sum += A[i];
                        }
                    }
                    cipherText.Add(sum);
                }
            }
            else
            {
                // General case for N bits (simplified for now to throw error if not 8)
                throw new NotImplementedException("Only N=8 (byte-level) encryption is supported for simplicity.");
            }

            return cipherText.ToArray();
        }

        public string Decrypt(BigInteger[] cipherText)
        {
            if (B == null) throw new InvalidOperationException("Keys not generated.");

            List<byte> bytes = new List<byte>();

            foreach (BigInteger C in cipherText)
            {
                // 1. Calculate S' = C * t^-1 mod m
                BigInteger S_prime = (C * tInverse) % m;

                // 2. Solve superincreasing knapsack for S'
                byte b = 0;
                // We must iterate backwards from largest element (b_{n-1}) to smallest (b_0)
                for (int i = N - 1; i >= 0; i--)
                {
                    if (S_prime >= B[i])
                    {
                        S_prime -= B[i];
                        // Set i-th bit
                        b |= (byte)(1 << i);
                    }
                }
                bytes.Add(b);
            }

            return Encoding.UTF8.GetString(bytes.ToArray());
        }
    }
}
