// Hello Username

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username == "Настя")
{
    Console.WriteLine("Ура, это же НАСТЯ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}