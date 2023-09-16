// Вывод третьей цифры (разряда) в заданном числе
using System;
using static System.Console;
Clear();

int ParseLine(string text) 
{
    WriteLine(text);
    string value = ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int ThreeDigestRank(int digest)
{
    while (digest > 999)
    {
        digest /= 10;
    }
    return digest % 10;
}

bool ValidateDigest(int digest)
{
    if (digest < 100)
    {
        WriteLine("В данном примере нет третьей цифры (разряда)");
        return false;
    }
    return true;
}

int digest = ParseLine("Введите числовое значение: ");
if (ValidateDigest(digest))
{
    WriteLine(ThreeDigestRank(digest));
}




