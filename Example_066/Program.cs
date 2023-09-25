// Example_066 Fibonacci Digests (No recursive method)
using System;
using static System.Console;
Clear();
// Use methods

Write("Введите переменную N:");
int N = int.Parse(ReadLine());
PrintNumbers(0,1,N);

void PrintNumbers(int a1, int a2, int size)
{
    Write($"{a1} {a2} ");
    for(int i = 0; i < size - 2; i++)
    {
        Write($"{a1 + a2} ");
        int k =  a1 + a2;
        a1 = a2;
        a2 = k;
    }
}

