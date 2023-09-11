// Сравнение трёх чисел

using System;
Console.Clear();
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int C = Convert.ToInt32(Console.ReadLine());

    if (A > B)
    {
        Console.Write($"Число A больше и оно равняется: {A}");
    }
    else if (B > C)
    {
        Console.Write($"Число B больше и оно равняется: {B}");
    }
    else 
    {
        Console.Write($"Число C больше и оно равняется: {C}");
    }
