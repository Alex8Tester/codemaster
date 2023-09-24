/* Example_058 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
using System;
using static System.Console;
Clear();
// Method use 

int size = Vvod("Введите длину массива");
int [] numbers = new int[size];
FillArrayRandomDigest(numbers);
MinMaxDiff(numbers);
PrintArray(numbers);

int Vvod(string message)
{
    WriteLine(message);
    string readMessage = ReadLine();
    int result = int.Parse(readMessage);
    return result; 
}

void FillArrayRandomDigest(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,100);
    }
}

void MinMaxDiff(int[] array)
{
    int min = numbers[0];
    int max = numbers[0];

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
        else if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    WriteLine($"Минимальное число в массиве: {min}");
    WriteLine($"Максимальное число в массиве: {max}");
    WriteLine($"Разница между минимальным и максимальным = {max-min}");
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