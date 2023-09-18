// Числа от 1 до N, вывести квадрат числа N
using System;
using static System.Console;
Clear();

Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

for(int i=1;i<=N;i++)
{
    Write($" {Math.Pow(i,2)} ");
}