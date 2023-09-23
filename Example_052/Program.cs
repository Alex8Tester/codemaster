// Example_052 
using System;
using static System.Console;
Clear();
// Method use 

int size = Vvod("Введите длину массива");
int minimalDigest = Vvod("Введите минимальный элемент массива");
int maximalDigest = Vvod("Введите максимальный элемент массива");
int DigestN = Vvod("Введите искомое число");
int [] array = RandomArray(size, minimalDigest, maximalDigest);
PrintArray(array);

if(FindElement(array,DigestN))
{
    WriteLine($"Указанный элемент {DigestN} найден в массиве");
}
else
{
    WriteLine($"Элемент {DigestN} не найден в массиве");
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

bool FindElement(int[] array, int DigestN)
{
    foreach(int item in array)
    {
        if(item==DigestN) return true;
    }
    return false;
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