// Четное или нечетное

using System;
Console.Clear();
Console.Write("Введите число для проверки: ");
int N = Convert.ToInt32(Console.ReadLine());
    
if (N % 2 == 0)
    {
        Console.Write("Ваше число - четное и оно делится на 2");
    }
else
    {
        Console.Write("Число нечетное - оно не делится на 2");
    }    