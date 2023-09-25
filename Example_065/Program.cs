// Example_065 Conversion to number systems
using System;
using static System.Console;
Clear();
// Use Methods

WriteLine("Введите ваше число: ");
int n = int.Parse(ReadLine());

// One method
string s1 = Convert.ToString(n,2);
WriteLine(s1);

string s2 = ConversionMethod(n,8);
WriteLine(s2);

// Two method

string ConversionMethod(int number, int convert)
{
    string result = "";
    string chars = "0123456789ABCDEF";
    while(number > 0)
    {
        int k = number / convert;
        int ost = number - k * convert;
        result = chars[ost].ToString() + result;
        number /= convert;
    }
    return result;
}