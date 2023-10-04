/* Example_088 Задайте значение N. 
Напишите программу, которая выведет все натуральные числа 
в промежутке от 1 до N 
*/
using System;
using System.Linq;
using static System.Console;
Clear();

// Code

int N = InputText("Введите число N: ");
WriteLine(PrintNumber(1,N));

// Methods

int InputText(string message)
{
    Write(message);
    string readMessage = ReadLine();
    int result = Convert.ToInt32(readMessage);
    return result;
}

string PrintNumber(int start, int end)
{
    if(start == end) return start.ToString();
    return(start + " " + PrintNumber(start + 1, end) );
}
