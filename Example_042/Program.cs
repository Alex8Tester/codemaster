// Example_042 Number 1 do A
using System;
using static System.Console;
Clear();

// Using method

WriteLine("Введите число A: ");
int A=int.Parse(ReadLine());
int summa=GetSumNumbers(A);
WriteLine($"Сумма = {summa}");

int GetSumNumbers(int number)
{
    int sum=0;
    for(int i=1;i<=number;i++)
    {
        sum+=i;
    }
    return sum;
}