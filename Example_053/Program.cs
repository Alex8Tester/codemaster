// Example_052 
using System;
using static System.Console;
Clear();
// Method use 
WriteLine("Введите через пробел массив:");
int[] array = GetArrayFromString(ReadLine());

Write("Введите элемент: ");
int element = int.Parse(ReadLine());

if(FindElement(array,element))
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");
}


int [] GetArrayFromString(string stringArray)
{
    string[] numS=stringArray.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}

bool FindElement(int[] inArray, int el)
{
    foreach(int item in inArray)
    {
        if(item==el) return true;
    }
    return false;
}
