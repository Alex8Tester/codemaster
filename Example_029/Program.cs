// Два числа (Число А квадрат Б) или наоборот
using System;
using static System.Console;
Clear();

Write("Введите число A: ");
int A=int.Parse(ReadLine());
Write("Введите число B: ");
int B=int.Parse(ReadLine());
    
    if (B * B == A)
    {
        WriteLine($"Да, число B = {B} является квадратом числа A = {A}");
    }
    else
    {   
        if (Math.Pow(A, 2) == B)
        {
            WriteLine($"Да A = {A} является квадратом числа B = {B}");        
        }
        else
        {
            WriteLine("Число А не является квадратом числа B, как и ровно наоборот");
        }
    }
