/* Example_056 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

using System;
using static System.Console;
Clear();
// Method use 

int size = Vvod("Введите длину массива");
int [] numbers = new int[size];
FillArrayRandomDigest(numbers);
FindChetNumbers(numbers);
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
        array[i] = new Random().Next(100,1000);
    }
}

void FindChetNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            count++;
        }
    WriteLine($"Количество четных чисел в массиве = {count}");
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