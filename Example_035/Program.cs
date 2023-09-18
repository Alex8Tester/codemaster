// Координаты X и Y, Теорема Пифагора
using System;
using static System.Console;
Clear();

Write("Введите координату X1: ");
int X1=int.Parse(ReadLine());
Write("Введите координату Y1: ");
int Y1=int.Parse(ReadLine());
Write("Введите координату X2: ");
int X2=int.Parse(ReadLine());
Write("Введите координату Y2: ");
int Y2=int.Parse(ReadLine());

double D = Math.Sqrt(Math.Pow(X1-X2,2)+Math.Pow(Y1-Y2,2));
WriteLine($"Длина отрезка = {D:f2}");

