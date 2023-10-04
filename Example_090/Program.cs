/* Example_090 Напишите программу,
которая будет принимать на вход число 
и возвращать сумму его цифр
*/
using System;
using System.Linq;
using static System.Console;
Clear();

// Code

int N = InputText("Введите число N: ");
WriteLine($"Сумма цифр числа = {PrintNumber(N)}");

// Methods

int InputText(string message)
{
    Write(message);
    string readMessage = ReadLine();
    int result = Convert.ToInt32(readMessage);
    return result;
}

int PrintNumber(int sum)
{
    if(sum == 0) return 0;
    return(sum % 10 + PrintNumber(sum / 10));
}