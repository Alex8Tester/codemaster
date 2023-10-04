/* Example_087 Заполните спирально массив 4 на 4.
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/
using System;
using static System.Console;
Clear();

// Code 

int n = 4;
int[,] SpiralArray = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= SpiralArray.GetLength(0) * SpiralArray.GetLength(1))
{
  SpiralArray[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < SpiralArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= SpiralArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > SpiralArray.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(SpiralArray);

// Methods

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}