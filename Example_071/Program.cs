/* Example_71 Задайте двумерный массив размером M x N, 
заполненный случайными целыми числами */
using System;
using static System.Console;
Clear();

// Code
int m = InputText("Введите количество строк: ");
int n = InputText("Введите количество столбцов: ");
int[,] array = GetArray(m, n);
WriteLine();
PrintArray(array);

// Methods

int InputText(string message)
{
    Write(message);
    string readMessage = ReadLine();
    int result = Convert.ToInt32(readMessage);
    return result;
}

int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = i + j;
        }
    }
    return result;
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