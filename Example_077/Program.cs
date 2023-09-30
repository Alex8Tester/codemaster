// Парсинг входящей строки (Задача на лекции)
using System;
using System.Linq;
using static System.Console;
Clear();

// code

string text = "(1,2) (2,3) (4,5) (9,7)"
                .Replace("(", "")
                .Replace(")", "")
                ;
WriteLine(text);

var data = text.Split(" ")
                .Select(item => item.Split(','))
                .Select(array => (x: int.Parse(array[0]), y: int.Parse(array[1])))
                .Where(array => array.x % 2 == 0)
                .Select(point => (point.x * 10, point.y + 10))
                .ToArray();
for (int i = 0; i < data.Length; i++)
{
   WriteLine(data[i]);
}




