/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/
using System;
using System.Linq;
using static System.Console;
Clear();

// Code

int m = InputText("Введите количество строк: ");
int n = InputText("Введите количество столбцов: ");
int range = InputText("Ввеедите диапазон от 1 до ");

int[,] array = new int [m, n];
GetArray(array);
PrintArray(array);

int minSumRow = 0;
int sumRow = SumRowsElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSum = SumRowsElements(array, i);
  if (sumRow > tempSum)
  {
    sumRow = tempSum;
    minSumRow = i;
  }
}
WriteLine($"Это строка: {minSumRow + 1} -  с наименьшшей суммой элементов, равной: ({sumRow})");

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

int SumRowsElements(int[,] array, int i)
{
  int sumRow = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRow += array[i,j];
  }
  return sumRow;
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