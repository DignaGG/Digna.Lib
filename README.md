# Digna.Lib

**Digna.Lib** is a high-performance, modular, and scalable C# core library. It serves as the foundational architecture of the Digna ecosystem, providing computational mathematics and efficiency-oriented algorithms.

## 🏗 Architectural Philosophy
Digna.Lib is engineered with a **"Performance-First"** mindset, adhering to rigorous software engineering principles:
- **Modular Design:** Each mathematical domain (e.g., Combinatorics, Algebra, Geometry) is isolated within its own namespace to ensure high cohesion and low coupling.
- **Hybrid Computational Engine:** Implements a dual-gear mechanism that utilizes primitive types (long) for low-range inputs and arbitrary-precision types (BigInteger) for high-range inputs, optimizing CPU register usage and memory allocation.
- **Stateless Execution:** Functions are designed as "Pure Functions," ensuring zero side effects and predictable output for identical inputs.

## 🚀 Roadmap & Current Modules
### Digna.Lib.Math.Combinatorics
- [x] `Factorial(int n)`: Optimized hybrid calculation engine.
- [ ] `Permutation(int n, int r)`: (In Progress)
- [ ] `Combination(int n, int r)`: (Planned)

## 💻 Installation & Usage
```csharp
using Digna.Lib.Math.Combinatorics;

// Example Usage
BigInteger result = CombinatorialMath.Factorial(25);
