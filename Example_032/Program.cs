// Дни недели - проверить будний день или выходной
using System;
using static System.Console;
Clear();

Console.Write("Введите число дня недели от 1 до 7: ");
int number = Convert.ToInt32(ReadLine());

void CheckTheDay(int number) {
    if (number > 0 && number < 5)
        {
            WriteLine($"Это {number} и это будний день");
        }
    else if (number == 6 || number == 7)
        {
            WriteLine($"Это {number} и это выходной день");
        }
    else if (number == 0 || number > 7)
        {
            WriteLine("А это вообще не день недели, попробуй снова");
        }
}
CheckTheDay(number);