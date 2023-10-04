/* Example_088 Задайте значение M и N. 
Напишите программу, которая выведет все натуральные
числа в промежутке от M до N
*/
using System;
using System.Linq;
using static System.Console;
Clear();

// Code

int M = InputText("Введите число M: ");
int N = InputText("Введите число N: ");
WriteLine(PrintNumber(M, N));

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