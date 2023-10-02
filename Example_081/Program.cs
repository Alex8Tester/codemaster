/* Показать треугольник Паскаля.
*Сделать вывод в виде равнобедренного треугольника.
*/

/*
                    1
                1       1
            1       2       1
        1       3       3       1
    1       4       6       4       1
1       5       10      10      5       1
*/

using System;
using static System.Console;
Clear();

// Code
int rows =  InputText("Введите количество строк: ");
PrintTriangle(rows);

// Methods

int InputText(string message)
{
    Write(message);
    string readMessage = ReadLine();
    int result = Convert.ToInt32(readMessage);
    return result;
}

void PrintTriangle(int n)
{
    for(int i=0; i < n; i++)
    {
        for(int c = 0; c<=(n-i); c++)
        {
            Write("  ");
        }
        for (int c = 0; c <= i; c++)
        {
            Write("   ");
            Write(factorial(i)/(factorial(c)*factorial(i-c)));
        }
    WriteLine();
    }
}

int factorial(int n)
{
    int f = 1;
    for (int i = 1; i <= n; i++)
    {
        f*=i;
    }
    return f;
}

