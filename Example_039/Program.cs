// Методы в C# 
// 1 Вид методов
using System;
using static System.Console;
Clear();

//void Method1()
//{
//    WriteLine("Author ...");
//}
// Method1();

// 2 Вид методов

// void Method2(string msg)
//{
//    WriteLine(msg);
//}
// Method2(msg: "Example");

// void Method21(string msg, int count)
//{
//    int i = 0;
//    while (i < count)
//    {
//        WriteLine(msg);
//        i++;
//    }
//}
// Method21(msg: "Текст сообщения:", count: 4);
// Method21(count: 4, msg: "Example Text 2");

// 3 Вид методов

// int Method3()
//{
//    return DateTime.Now.Year;
//}
// int year = Method3();
// WriteLine(year);

// 4 Вид методов

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "Zz");
// WriteLine(res);

// Examples on method and function

// string Method41(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method41(10, "Zz");
// WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        WriteLine($"{i} x {j} = {i*j}");
    }
    WriteLine();    
}

