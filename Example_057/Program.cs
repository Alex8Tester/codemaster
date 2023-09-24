/* Example_57 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
using System;
using static System.Console;
Clear();
// Method use 
int size = Vvod("Введите длину массива");
int [] numbers = new int[size];
FillArrayRandomDigest(numbers);
FindSumNegative(numbers);
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
        array[i] = new Random().Next(-10,10);
    }
}

void FindSumNegative (int[] array)
{
    int SumNegative = 0;
    for (int i = 0; i < numbers.Length; i++)
        {
            SumNegative += numbers[i];
        }
    WriteLine($"Сумма элементов стоящих в нечетных позициях = {SumNegative}");
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