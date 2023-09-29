/* Example_73 Задайте двумерный массив. 
Найдите сумму элементов, находящихся 
на главной диагонали (с индексами (0,0); (1,1) и т.д*/
using System;
using static System.Console;
Clear();

// Code
int m = InputText("Введите количество строк: ");
int n = InputText("Введите количество столбцов: ");
int[,] array = GetArray(m, n, -10, 10);
PrintArray(array);
WriteLine($"Сумма = {GetSumInArray(array)}");

// Methods

int InputText(string message)
{
    Write(message);
    string readMessage = ReadLine();
    int result = Convert.ToInt32(readMessage);
    return result;
}

int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

int GetSumInArray(int[,] inArray)
{
    int sum = 0;
    int length = inArray.GetLength(0);
    if(length > inArray.GetLength(1)) length = inArray.GetLength(1);
    for (int i = 0; i < length; i++)
    {
        sum += inArray[i,i];
    }
    return sum;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}
