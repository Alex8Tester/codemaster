// Вывод второй цифры (разряда) в трёхзначном числе
using System;
using static System.Console;
Clear();

WriteLine("Введите трёхзначное число: ");
int ThreeDigestNumber = int.Parse(ReadLine());

if (ThreeDigestNumber > 100 && ThreeDigestNumber < 1000)
{
    WriteLine($"Введенное число {ThreeDigestNumber} где второе число равно {ThreeDigestNumber / 10 % 10}");
}
else
{
    WriteLine ("Вы ввели число не соответствующее трехзначному, попробуйте заново");
}


