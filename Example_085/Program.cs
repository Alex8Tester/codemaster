/* Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2         1 5 8 5         1 20 56 10
5 9 2 3    *    4 9 4 2     =   20 81 8 6
8 4 2 4         7 2 2 6         56 8 4 24
5 2 6 7         2 3 4 7         10 6 24 49

*/

using System;
using System.Linq;
using static System.Console;
Clear();

// Code

int m = InputText("Введите число строк 1-й матрицы: ");
int n = InputText("Введите число столбцов 1-й матрицы (И строк для 2-й матрицы): ");
int p = InputText("Введите число столбцов 2-й матрицы: ");
int range = InputText("Введите диапазон чисел для обеих матриц от 1 до:");

int[,] firstArray = new int[m, n];
GetArray(firstArray);
WriteLine("Это первая матрица:");
PrintArray(firstArray);

int[,] secondArray = new int[n, p];
GetArray(secondArray);
WriteLine("Это вторая матрица:");
PrintArray(secondArray);

int[,] resultArray = new int[m, p];

MultiplyArray(firstArray, secondArray, resultArray);
WriteLine($"Произведение матриц равно: ");
PrintArray(resultArray);

// Methods

int InputText(string message)
{
    Write(message);
    string readMessage = ReadLine();
    int result = Convert.ToInt32(readMessage);
    return result;
}

void GetArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void MultiplyArray(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{

    for (int i = 0; i < resultArray.GetLength(0); i++)
        {
            for (int j = 0; j < resultArray.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < firstArray.GetLength(1); k++)
                        {
                            sum += firstArray[i,k] * secondArray[k,j];
                        }
            resultArray[i,j] = sum;
            }
        }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write(inArray[i,j] + " ");
        }
        WriteLine();
    }
}

