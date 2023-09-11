// Проверить является ли первое число, квадратом второго

Console.Clear();

Console.Write("Введите число A: ");
int A=int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int B=int.Parse(Console.ReadLine());
    
    if (B * B == A)
    {
    Console.WriteLine("yes");
    }
    else
    { 
    Console.WriteLine("no");
    }
