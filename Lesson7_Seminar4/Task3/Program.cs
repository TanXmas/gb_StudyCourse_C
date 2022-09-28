/* Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120 */


void printWithColor(string infoForUser, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(infoForUser);
    Console.ResetColor();
}


int getNumberFromUser(string infoForUser)
{
    int number = 0;
    while (number == 0)
    {
        //Console.Write(infoForUser);
        printWithColor(infoForUser, ConsoleColor.DarkBlue);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out number);
        if (number < 0) number = 0;
    }
    return number;
}


int getFactorial(int number)
{
    int fact = 1;
    for (int i = 2; i <= number; i++)
        fact *= i;
    return fact;
}


int number = getNumberFromUser("Введите целое положительное число: ");
int fact = getFactorial(number);
printWithColor($"Произведение чисел от 1 до {number} = {fact}", ConsoleColor.DarkGreen);
