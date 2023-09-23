// Example_047 принимаем на вход число и возвращаем сумму цифр в нем
using System;
using static System.Console;
Clear();
// Method use 
int sum = Vvod("Введите вашу цифру");
WriteLine($"Сумма цифр в числе {sum} = {sumDigit(sum)}");


int Vvod(string message)
{
    WriteLine(message);
    string readMessage = ReadLine();
    int result = int.Parse(readMessage);
    return result; 
}

int sumDigit(int sum)
{
    int result = 0;
    while (sum > 0)
    {
        result += sum % 10;
        sum = sum / 10;
    }
    return result;
}