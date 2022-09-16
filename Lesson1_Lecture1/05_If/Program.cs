Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Маша, привееет!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}