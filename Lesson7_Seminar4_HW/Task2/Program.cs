/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int getNumberFromUser(string infoForUser)
{
    int number = 0;
    while (number == 0)
    {
        Console.Write(infoForUser);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out number);
        if (number < 0) number = 0;
    }
    return number;
}

int getSumNumberOfDigits(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

int number = getNumberFromUser("Введите натуральное число: ");
int sumNumberOfDigits = getSumNumberOfDigits(number);
Console.WriteLine($"Сумма цифр в числе {number} = {sumNumberOfDigits}");
