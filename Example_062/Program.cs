// Example_062 Fibonacci Digests (Recursive method)
using System;
using static System.Console;
Clear();
// Use methods
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 50; i++)
{
    WriteLine($"f({i}) -> {Fibonacci(i)}");
}
