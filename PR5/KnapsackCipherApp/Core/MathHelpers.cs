using System;
using System.Numerics;

namespace KnapsackCipherApp.Core
{
    public static class MathHelpers
    {
        // Greatest Common Divisor
        public static BigInteger GCD(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Modular Inverse using Extended Euclidean Algorithm
        // Returns x such that (a * x) % m == 1
        public static BigInteger ModularInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m;
            BigInteger y = 0, x = 1;
 
            if (m == 1) return 0;
 
            while (a > 1)
            {
                // q is quotient
                BigInteger q = a / m;
                BigInteger t = m;
 
                // m is remainder now, process same as Euclid's algo
                m = a % m;
                a = t;
                t = y;
 
                // Update y and x
                y = x - q * y;
                x = t;
            }
 
            // Make x positive
            if (x < 0) x += m0;
 
            return x;
        }

        // Check if a and b are coprime
        public static bool AreCoprime(BigInteger a, BigInteger b)
        {
            return GCD(a, b) == 1;
        }
    }
}
