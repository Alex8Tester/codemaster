/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2:

12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
*/

using System;
using static System.Console;
Clear();

// Code

int x = InputText("Введите число строк в линии X: ");
int y = InputText("Введите число строк в линии Y: ");
int z = InputText("Введите число строк в линии Z: ");

WriteLine($"");
int[,,] matrix3D = new int [x, y, z];
GetArray(matrix3D);
PrintArray(matrix3D);

// Methods

int InputText(string message)
{
    Write(message);
    string readMessage = ReadLine();
    int result = Convert.ToInt32(readMessage);
    return result;
}

void GetArray(int[,,] matrix3D)
{
  for (int i = 0; i < matrix3D.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3D.GetLength(1); j++)
    {
        Write($"X({i}) Y({j}) ");
        for (int k = 0; k < matrix3D.GetLength(2); k++)
        {
            Write( $"Z({k})={matrix3D[i,j,k]}; ");
        }
        WriteLine();
    }
     WriteLine();
  }
}

void PrintArray(int[,,] matrix3D)
{
  int[] temp = new int[matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2)];
  int number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(11, 99);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(11, 99);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < matrix3D.GetLength(0); x++)
  {
    for (int y = 0; y < matrix3D.GetLength(1); y++)
    {
      for (int z = 0; z < matrix3D.GetLength(2); z++)
      {
        matrix3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}


