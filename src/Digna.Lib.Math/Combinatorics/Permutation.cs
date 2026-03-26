// -----------------------------------------------------------------------------------------
// Author: DignaGG
// Project: Digna.Lib.Math
// Description: Hybrid-engine permutation calculator.
// Note: English XML documentation was translated from the original Turkish design notes.
// -----------------------------------------------------------------------------------------

using System.Numerics;

namespace Digna.Lib.Math.Combinatorics
{
    public static class Permutation
    {
        /// <summary>
        /// Calculates the permutation P(n, r) using a hardware-optimized hybrid engine and O(1) short-circuits.
        /// </summary>
        /// <param name="n">The total number of elements. Must be between 0 and 10,000.</param>
        /// <param name="r">The number of elements to select. Must be between 0 and n.</param>
        /// <returns>A BigInteger representing the number of permutations.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when n or r falls outside their valid mathematical or system thresholds.</exception>
        public static BigInteger CalculatePermutation(int n, int r)
        {
            // 1. Fail-Fast Validation
            if (n < 0 || n > 10000) throw new ArgumentOutOfRangeException(nameof(n), "The input value must be between 0 and 10,000.");
            if (r < 0 || r > n) throw new ArgumentOutOfRangeException(nameof(r), "The input value must be between 0 and n.");

            // 2. Short-Circuit Returns
            if (r == 0) return BigInteger.One;
            if (r == 1) return (BigInteger)n;
            if (r == n) return Factorial.CalculateFactorial(n);

            // 3. Low-Range Engine (n <= 20)
            if (n <= 20)
            {
                long lowResult = 1;
                for (int i = n; i >= (n - r + 1); i--) lowResult *= i;
                return (BigInteger)lowResult;
            }

            // 4. High-Range Engine (n > 20)
            BigInteger highResult = BigInteger.One;
            for (int i = n; i >= (n - r + 1); i--) highResult *= i;
            return highResult;
        }
    }
}