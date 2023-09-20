// Методы в C# Примеры Задач

using System;
using static System.Console;
Clear();

// ====== Работа с текстом ======
//Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы "к" заменить большими "К",
//а больше "С" заменить маленькими "с"

string text = "- Я думаю, - Сказал князь, улыбаясь, - что, "
            + "ежели бы ваС поСлали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие пруССкого короля. "
            + "Вы так краСноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
WriteLine(newText);
WriteLine();

newText = Replace(newText, 'к', 'К');
WriteLine(newText);
WriteLine();

newText = Replace(newText, 'С', 'с');
WriteLine(newText);
WriteLine();