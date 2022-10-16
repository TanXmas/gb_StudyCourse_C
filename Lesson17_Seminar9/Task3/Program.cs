/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. */

int getNumberFromUser(string infoForUser)
{
    int number = 0;
    while (number == 0)
    {
        Console.Write(infoForUser);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out number);
        if (userLine == "0") break;
        if (number < 0) number = 0;
    }
    return number;
}


int getSumDigits(int n)
{
    if (n == 0)
        return 0;
    else
        return n % 10 + getSumDigits(n / 10);
}


int n = getNumberFromUser("Введите натуральное число: ");
int sumDigits = getSumDigits(n);
Console.WriteLine($"Сумма цифр {n} = {sumDigits}");
