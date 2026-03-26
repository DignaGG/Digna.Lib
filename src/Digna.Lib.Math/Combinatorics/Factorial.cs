// -----------------------------------------------------------------------------------------
// Author: DignaGG
// Project: Digna.Lib.Math
// Description: Hybrid-engine factorial calculator.
// Note: English XML documentation was translated from the original Turkish design notes.
// -----------------------------------------------------------------------------------------

using System.Numerics;

namespace Digna.Lib.Math.Combinatorics
{
    public static class Factorial
    {
        // Maximum factorial value representable by a 64-bit signed integer (long). 
        // Used as a pre-computed threshold to eliminate redundant CPU cycles.
        private const long FACTORIAL_20 = 2432902008176640000;

        /// <summary>
        /// Calculates the factorial of a given non-negative integer using a hybrid performance engine.
        /// </summary>
        /// <param name="n">The target integer. Must be between 0 and 10,000.</param>
        /// <returns>A BigInteger representing the factorial of n.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when n is negative or exceeds the system health threshold (10,000).</exception>
        public static BigInteger CalculateFactorial(int n)
        {
            // 1. Fail-Fast Validation
            if (n < 0 || n > 10000)  throw new ArgumentOutOfRangeException(nameof(n), "The input value must be between 0 and 10,000.");

            // 2. Short-Circuit Returns
            if (n == 0 || n == 1) return BigInteger.One;
            if (n == 20) return (BigInteger)FACTORIAL_20;

            // 3. Low-Range Engine (n < 20)
            if (n < 20)
            {
                long lowResult = 1;
                for (int i = 2; i <= n; i++) lowResult *= i;
                return (BigInteger)lowResult;
            }

            // 4. High-Range Engine (n > 20)
            BigInteger highResult = FACTORIAL_20;
            for (int i = 21; i <= n; i++) highResult *= i;
            return highResult;
        }
    }
}