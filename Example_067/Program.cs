// Example_067 Array copied method (Elementary method)
using System;
using static System.Console;
Clear();
// Use methods
WriteLine("Введите массив через пробел: ");
int[] array = GetArrayFromString(ReadLine());

int[] arrayCopy = CopyArray(array);
WriteLine(String.Join(" ",arrayCopy));

int[] array2 = array;
WriteLine(String.Join(" ",array2));

array[2] = 100;
WriteLine(String.Join(" ",array2));

int[] CopyArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = inArray[i];
    }
    return result;
}

int[] GetArrayFromString(string arrayString)
{
    string[] nums = arrayString.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];
    for (int i = 0; i < result.Length; i++)
    {
       result[i] = Convert.ToInt32(nums[i]);
    }
    return result;
}