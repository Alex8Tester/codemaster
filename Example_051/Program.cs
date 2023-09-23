// Example_051 Array on 8 digest, replace all negative elements to positive and backward
using System;
using static System.Console;
Clear();
// Method use 

int[] array = RandomArray(8,-10,10);
WriteLine(String.Join(" ",array));
InversiveArray(array);
WriteLine(String.Join(" ",array));


int[] RandomArray(int size, int min, int max)
{
    int [] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i]= new Random().Next(min, max + 1);
    }
    return result;
}

void InversiveArray(int [] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        inArray[i] *= -1;
    }
}
