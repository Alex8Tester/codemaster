// Example_044 Числа от 1 до N произведение чисел
using System;
using static System.Console;
Clear();
// Method use 

WriteLine("Введите число N: ");
int N=int.Parse(ReadLine());
int sum=SummaryNum(N);
WriteLine($"Сумма = {sum}");

int SummaryNum(int number)
{
    int num=1;
    for(int i=1;i<=number;i++)
    {
       num = num * i; 
    }
    return num;
}
