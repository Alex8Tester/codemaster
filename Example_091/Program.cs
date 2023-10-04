/* Example_090 Напишите программу,
которая будет принимать на вход число 
и возвращать сумму его цифр */
using System;
using System.Linq;
using static System.Console;
Clear();

// Code

int A = InputText("Введите число: ");
int B = InputText("Введите показатель степени: ");
WriteLine($"Число {A} в степени {B} = {NaturalSum(A,B)}");

// Methods

int InputText(string message)
{
    Write(message);
    string readMessage = ReadLine();
    int result = Convert.ToInt32(readMessage);
    return result;
}

int NaturalSum(int naturalDigit, int exponenceDigit)
{
    if(exponenceDigit == 0) return 1;
    if(exponenceDigit == 1) return naturalDigit;
    return (naturalDigit * NaturalSum(naturalDigit,exponenceDigit - 1));
}
