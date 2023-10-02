/* Задайте двумерный массив. 
Напишите программу которая поменяет местами 
первую и последнюю строку массива*/

using System;
using System.Linq;
using static System.Console;
Clear();

// Code

int m = InputText("Введите количество строк: ");
int n = InputText("Введите количество столбцов: ");


if (m!=n)
{
    WriteLine("Такой массив изменить нельзя!");
    return;
}

int[,] array = GetArray(m, n, 0, 10);
PrintArray(array);

int[,] newArray = GetChangeArray(array);
WriteLine();
PrintArray(newArray);



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

int[,] GetChangeArray(int[,] inArray)
{
    int[,] result = new int[inArray.GetLength(0),inArray.GetLength(0)];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[j,i] = inArray[i,j];
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