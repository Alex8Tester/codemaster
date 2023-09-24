// Example_059 TwoDimensional array
using System;
using static System.Console;
Clear();
// Examples:
//тип //Разделитель // Имя массива // тип (строковый) // кол-во строк(2) //кол-во столбцов(5)
// string[,] table = new string [2, 5];
// String.Empty
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4] 
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]

// table[1, 2] = "Word";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         WriteLine($"-{table[rows, columns]}-");
//     }
// }
int[,] matrix = new int[3, 4];
FillArrayRandomDigest(matrix);
PrintArray(matrix);

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Write($"{matr[i, j]} ");
            }
        WriteLine();
        }
}

void FillArrayRandomDigest(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);// [1; 10]
        }
    }
}