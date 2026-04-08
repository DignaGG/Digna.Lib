// -----------------------------------------------------------------------------------------
// Author: DignaGG
// Project: Digna.Lib.Math
// Description: Hybrid-engine combination calculator with symmetry optimization.
// Note: English XML documentation was translated from the original Turkish design notes.
// -----------------------------------------------------------------------------------------

using System.Numerics;

namespace Digna.Lib.Math.Combinatorics
{
    public static class Combination
    {
        /// <summary>
        /// Calculates the combination C(n, r) using symmetry optimization and hybrid-engine delegation.
        /// </summary>
        /// <param name="n">The total number of elements. Must be between 0 and 10,000.</param>
        /// <param name="r">The number of elements to select. Must be between 0 and n.</param>
        /// <returns>A BigInteger representing the number of combinations.</returns>
        public static BigInteger CalculateCombination(int n, int r)
        {
            // 1. Fail-Fast Validation
            if (n < 0 || n > 10000) throw new ArgumentOutOfRangeException(nameof(n), "The input value must be between 0 and 10,000.");
            if (r < 0 || r > n) throw new ArgumentOutOfRangeException(nameof(r), "The input value must be between 0 and n.");

            //2. Symmetry Logic
            if (r > n / 2) r = n - r;

            // 3. Short-Circuit Returns
            if (r == 0) return BigInteger.One;
            if (r == 1) return (BigInteger)n;

            //4. Core Execution
            BigInteger numerator = Permutation.CalculatePermutation(n, r);
            BigInteger denominator = Factorial.CalculateFactorial(r);
            return numerator / denominator;
        }
    }
}