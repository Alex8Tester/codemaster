// Вывод трехзначного числа и удаление второй цифры из этого числа   
using System;
using static System.Console;
Clear();

int ThreeDigestNumber = new Random().Next(100, 1000);
int a1 = ThreeDigestNumber / 100;
int a2 = ThreeDigestNumber % 10;

WriteLine($"Это трехзначное число: {ThreeDigestNumber} Удаляем вторую цифру и получаем: {a1*10+a2}");

