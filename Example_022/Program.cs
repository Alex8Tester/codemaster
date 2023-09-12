// Massive Example 2 Use Constant 

using System;
Console.Clear();

int[] array = {10, 21, 32, 87, 43, 54, 4, 76, 87};
int n = array.Length;
int find = 87;
int index = 0;

while (index < n)
{
    
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}
