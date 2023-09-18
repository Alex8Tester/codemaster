// Координаты X и Y, где X != 0 и Y != 0
using System;
using static System.Console;
Clear();

Write("Введите координату X: ");
int x=int.Parse(ReadLine());
Write("Введите координату Y: ");
int y=int.Parse(ReadLine());

if(x > 0 && y > 0)
{
    WriteLine("1 четверть");
}
if(x < 0 && y > 0)
{
    WriteLine("2 четверть");
}
if(x < 0 && y < 0)
{
    WriteLine("3 четверть");
}
if(x > 0 && y < 0)
{
    WriteLine("4 четверть");
}