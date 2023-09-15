// Число А кратно Б  
using System;
using static System.Console;
Clear();

Write("Введите число A: ");
double A = Convert.ToInt32(Console.ReadLine());
Write("Введите число B: ");
double B = Convert.ToInt32(Console.ReadLine());
double C = A % B;

if (A % B == 0)
{
    Write($"Число {B} кратно числу {A}");
}
else
{
    Write($"Число {B} некратно числу {A} где остаток от деления {C}");
}