// Сравнение трех чисел

using System;
Console.Clear();
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

    if (A > B)
    {
        Console.Write("Число A больше");
    }
    else
    {
        Console.Write("Число B больше");
    }