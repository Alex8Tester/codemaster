﻿// Трехзначное число

using System;
Console.Clear();
Console.Write("Введи трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int x = number%10;

Console.WriteLine(x);

// string stringNumber = Convert.ToString(number);
// Console.WriteLine("Третья цифра этого числа -> "+stringNumber[2]);


