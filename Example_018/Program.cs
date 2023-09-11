// Все четные числа от 1 до N
using System;

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int B = 1;

while(B <= N) 

if (B % 2 == 0)
{
    Console.Write($"{B} ");
    B++;
}
else
{
    B++;
}
