// Example_054
using System;
using static System.Console;
Clear();
// Method use 
int[] array = GetArray(10, 0, 1000);
WriteLine(String.Join(",",array));
int countElements = GetCountElements(array, 10, 99);
WriteLine($"Количество элементов в отрезке [10:99] = {countElements}");

int GetCountElements(int[] inArray, int leftRange, int rightRange)
{
    int count = 0;
    foreach(int item in inArray)
    {
        if(item >= leftRange && item <= rightRange)
        {
            count++;
        }
    }
    return count;
}


int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

