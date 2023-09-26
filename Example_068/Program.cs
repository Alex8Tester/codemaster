/* Example_068 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
using System;
using static System.Console;
Clear();
// Use methods

int length = Vvod("Введите общее количество элементов");
int[] array;
array = InputArray(length);
PrintArray(array);
WriteLine($"{CountPositive(array)} - количество чисел, которые больше нуля");

int Vvod(string message)
{
    WriteLine(message);
    string readMessage = ReadLine();
    int result = Convert.ToInt32(readMessage);
    return result; 
}

int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = Vvod($"Введите {i + 1} элемент");
        }
    return array;
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
       Write($"{array[i]}, "); 
    }
    Write($"{array[array.Length - 1]}");
    WriteLine("]");
}
