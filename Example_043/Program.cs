// Example_043 Количество цифр в числе
using System;
using static System.Console;
Clear();
// Method use

WriteLine("Введите число для подсчета цифр: ");
WriteLine($"Сумма = {(GetDigestOnNumber(int.Parse(ReadLine())))}");

int GetDigestOnNumber(int number)
{
    int count=0;
    while(number>0)
    {
        count++;
        number/=10;
    }
    return count;
}
