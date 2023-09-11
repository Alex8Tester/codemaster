Console.Clear();
Console.Write("Введи трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);
Console.WriteLine("Третья цифра этого числа -> "+stringNumber[2]);


