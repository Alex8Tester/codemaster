Console.Write("Введите имя пользователя: ");

string username = Console.ReadLine();

if(username.ToLower() == "nastya")
{
    Console.WriteLine("Ура, это же NASTYA!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
