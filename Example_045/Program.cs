// Example_045 Array Binary Random
using System;
using static System.Console;
Clear();
// Method use 
WriteLine($"[{string.Join(",",RandomBinaryArray(8))}]");


int[] RandomBinaryArray(int size)
{
    int [] array = new int[size];
    for(int i=0;i<size;i++)
    {
        array[i]=new Random().Next(0, 2);
    }
    return array;
}
