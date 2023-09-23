// Example_047 принимаем на вход число и возвращаем сумму цифр в нем
using System;
using static System.Console;
Clear();
// Method use 

int size = Vvod("Введите длину массива");
int minimalDigest = Vvod("Введите минимальный элемент массива");
int maximalDigest = Vvod("Введите максимальный элемент массива");
int [] array = RandomArray(size, minimalDigest, maximalDigest);
PrintArray(array);

int Vvod(string message)
{
    WriteLine(message);
    string readMessage = ReadLine();
    int result = int.Parse(readMessage);
    return result; 
}

int[] RandomArray(int length, int min, int max)
{
    int [] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i]= new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int [] array)
{
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
       Write($"{array[i]}, "); 
    }
    Write($"{array[array.Length - 1]}");
    WriteLine("]");
}


