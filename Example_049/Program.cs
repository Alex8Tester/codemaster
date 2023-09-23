// Example_049 Array on 12 digest, sum all negative elements
using System;
using static System.Console;
Clear();
// Method use 


int [] array = RandomArray(12, -9, 9);
int positiveSum = 0;
int negativeSum = 0;
WriteLine(String.Join(",",array));

foreach (int item in array)
{
    Write($"{item}");
    if(item > 0)
    {
        positiveSum += item;
    }
    else
    {
        negativeSum += item;
    }
}

int Vvod(string message)
{
    WriteLine(message);
    string readMessage = ReadLine();
    int result = int.Parse(readMessage);
    return result; 
}

int[] RandomArray(int size, int min, int max)
{
    int [] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i]= new Random().Next(min, max + 1);
    }
    return result;
}
WriteLine();
WriteLine($"Сумма положительных элементов = {positiveSum}, сумма отрицательных = {negativeSum}");