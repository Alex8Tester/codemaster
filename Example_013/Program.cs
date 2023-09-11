// Отрезок чисел от -N до N
using System;

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int B = -N;

while(B<=N)
{
    Console.Write($"{B} ");
    B++;
}
