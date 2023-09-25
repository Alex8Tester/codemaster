// Example_064 Triangle sides
using System;
using static System.Console;
Clear();
// Use Methods
WriteLine("Введите стороны треугольника через пробел");
string[] nums=ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
if(IsTriangle(int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2])))
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");
}

bool IsTriangle(int a, int b, int c)
{
    return (((a + b) > c) && ((b + c) > a) && ((a + c) > b));
}