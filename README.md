# Digna.Lib

**Digna.Lib** is a high-performance, modular, and scalable C# core library. It serves as the foundational architecture of the Digna ecosystem, providing computational mathematics and efficiency-oriented algorithms.

## 🏗 Architectural Philosophy
Digna.Lib is engineered with a **"Performance-First"** mindset, adhering to rigorous software engineering principles:
- **Modular Design:** Each mathematical domain (e.g., Combinatorics, Algebra, Geometry) is isolated within its own namespace to ensure high cohesion and low coupling.
- **Hybrid Computational Engine:** Implements a dual-gear mechanism that utilizes primitive types (long) for low-range inputs and arbitrary-precision types (BigInteger) for high-range inputs, optimizing CPU register usage and memory allocation.
- **Stateless Execution:** Functions are designed as "Pure Functions," ensuring zero side effects and predictable output for identical inputs.

## 🚀 Roadmap & Current Modules
### Digna.Lib.Math.Combinatorics
- [x] `Factorial(int n)`: Hybrid calculation engine with O(1) pre-computed thresholds.
- [x] `Permutation(int n, int r)`: Hybrid calculation engine with simplified range multiplication.
- [x] `Combination(int n, int r)`: Hybrid engine with O(1) symmetry optimization and cross-module delegation.

## 💻 Installation & Usage
```csharp
using Digna.Lib.Math.Combinatorics;

// Factorial Example Usage
BigInteger factorialResult = Factorial.CalculateFactorial(25);

// Permutation Example Usage
BigInteger permutationResult = Permutation.CalculatePermutation(25, 5);

// Combination Example usage
BigInteger combinationResult = Combination.CalculateCombination(25,5);
```

## ✍️ Author & Documentation Notes
**Author:** DignaGG (DignaSoftware)

**Design & Translation Note:** The core architecture, algorithms, and system logic of this library are natively designed and developed in Turkish. To comply with international open-source coding standards, the code comments, XML documentation, and this README were translated into English with AI assistance. The primary engineering focus remains strictly on mathematical accuracy, hardware-level optimization, and system stability.

License: This project is licensed under the MIT License - see the LICENSE file for details.
