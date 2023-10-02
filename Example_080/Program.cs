/* Из двумерного массива целых чисел удалить строку и столбец, 
на пересечении которых расположен первый найденный наименьший элемент.
*/

/*
Исходный массив:    Результат:
-1 4 7 2-           9 2 3
-5 9 2 3            4 2 4
-8 4 2 4            2 6 7
-5 2 6 7
*/

using System;
using System.Linq;
using static System.Console;
Clear();

// Code

int m = InputText("Введите количество строк: ");
int n = InputText("Введите количество столбцов: ");

int[,] startArray = GetArray(m, n,10, 99);
PrintArray(startArray);
WriteLine();
WriteLine($"Минимальный элемент массива в позиции {String.Join(";", GetMinIndex(startArray))}");
WriteLine();
PrintArray(GetResultArray(startArray,GetMinIndex(startArray)));


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

int[] GetMinIndex(int[,] inArray)
{
    int[] result = new int[]{0,0};
    int min = inArray[0,0];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (min>inArray[i,j])
            {
                min = inArray[i,j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

int [,] GetResultArray(int[,] inArray, int[] index)
{
    int [,] result = new int[inArray.GetLength(0)-1, inArray.GetLength(1)-1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i == index[0]) continue;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (j == index[1]) continue;
            result[row, column] = inArray[i,j];
            column++;
        }
        row++;
        column = 0;
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
