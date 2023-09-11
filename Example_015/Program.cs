// Сравнение двух чисел

using System;
Console.Clear();
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (A > B)
{
    Console.Write($"Число A больше и оно равняется {A}, число B меньше и оно равняется {B}");
}
else if (A < B)
{
    Console.Write($"Число B больше и оно равняется {B}, число A меньше и оно равняется {A}");
}
else if (A == B)
{
    Console.Write($"Число А {A} и Число B {B} равны");
}