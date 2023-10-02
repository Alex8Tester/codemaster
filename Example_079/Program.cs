/* Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных*/

/* 
   1,9,9        0 - встречается 3 раза    8 - встречается 1 раз
   0,2,8  -->   1 - встречается 1 раз     9 - встречается 3 раза
   0,9,0        2 - встречается 1 раз
*/

using System;
using System.Linq;
using static System.Console;
Clear();

// Code

int m = InputText("Введите количество строк: ");
int n = InputText("Введите количество столбцов: ");

int[,] array = GetArray(m, n, 0, 9);
PrintArray(array);
WriteLine();

int[] rowArrayIn = GetRowArray(array);
SortArray(rowArrayIn);
WriteLine(String.Join(" ",rowArrayIn));
PrintData(rowArrayIn);

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

int[] GetRowArray(int[,] inArray)
{
    int[] rowArray = new int [inArray.GetLength(0) * inArray.GetLength(1)];
    int index = 0;
    
    for (int i = 0; i < inArray.GetLength(0); i++)
            {
                for (int j = 0; j < inArray.GetLength(1); j++)
                {
                    rowArray[index] = inArray[i,j];
                    index++;
                }
            }
    return rowArray;
}

void SortArray(int[] rowArray)
{
    for (int i = 0; i < rowArray.Length; i++)
    {
        for (int j = i + 1; j < rowArray.Length; j++)
        {
            if(rowArray[i]>rowArray[j])
            {
                int tempArray = rowArray[i];
                rowArray[i] = rowArray[j];
                rowArray[j] = tempArray;
            }
        }
    }
}

void PrintData(int [] inArray)
{
    int element = inArray[0];
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i]!=element)
        {
            WriteLine($"{element} встречается {count} раз");
            element = inArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    WriteLine($"{element} встречается {count} раз");
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

