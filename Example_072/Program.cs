/* Example_72 Задайте двумерный массив. 
Найдите элементы, у которых оба индекса четные, 
и замените эти элементы на их квадраты*/
using System;
using static System.Console;
Clear();

// Code


Write("Введите количество строк и столбцов через пробел: ");
string[] nums = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetArray(int.Parse(nums[0]),int.Parse(nums[1]), 0, 10);
PrintArray(array);
WriteLine();
FillArraySqrt(array);
PrintArray(array);

// Methods

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

void FillArraySqrt(int[,] inArray)
{
    for (int i = 2; i < inArray.GetLength(0); i++)
    {
        for (int j = 2; j < inArray.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0)) inArray[i,j] *= inArray[i,j];
        }
    }
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
