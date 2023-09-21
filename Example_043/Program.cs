// Example_043 Количество цифр в числе
using System;
using static System.Console;
Clear();
// Method use

WriteLine("Введите число для подсчета цифр: ");
int A=int.Parse(ReadLine());
int nums=GetDigestOnNumber(A);
WriteLine($"Сумма = {nums}");

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
