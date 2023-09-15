// Число А кратно Б и C 
using System;
using static System.Console;
Clear();

Write("Введите число A: ");
double A = Convert.ToInt32(Console.ReadLine());

if ((A % 7 == 0)&&(A % 23 == 0))
{
    Write($"Число {A} кратно числам 7 и 23");
}
else
{
    Write($"Число {A} одновременно некратно числу 7(остаток: {A%7}) и числу 23(остаток: {A%23})");
}
