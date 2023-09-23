// Example_046 возведение A в натуральную степень B
using System;
using static System.Console;
Clear();
// Method use 

WriteLine("Введите число naturDigit: ");
int naturDigit=int.Parse(ReadLine());
WriteLine("Введите число expo: ");
int expo=int.Parse(ReadLine());

if (ValidateMethod(expo))
{
    WriteLine($"Число {naturDigit} возводим в {expo} и получаем: {NaturSum(naturDigit, expo)}");
}

int NaturSum(int naturDigit, int expo)
{
    int nature=1;
    for(int i = 0; i <= expo; i++)
    {
       nature = Convert.ToInt32(Math.Pow(naturDigit, expo));
    }
    return nature;
}

bool ValidateMethod(int expo)
{
    if(expo < 0)
    {
        WriteLine("Нулевое значение не выводим в степень");
        return false;
    }
    return true;
}
