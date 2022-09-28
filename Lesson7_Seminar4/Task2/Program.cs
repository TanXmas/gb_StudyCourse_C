/* Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */


void printWithColor(string infoForUser, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(infoForUser);
    Console.ResetColor();
}


int getNumberFromUser()
{
    int number = 0;
    while (number == 0)
    {
        printWithColor("Введите целое число: ", ConsoleColor.DarkBlue);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out number);
        if (userLine == "0") break;
        if (number < 0) number = 0;
    }
    return number;
}


int number = getNumberFromUser();

int colDigit = 1;
if (number != 0) colDigit = (int) Math.Log10(number)+1;
printWithColor($"Количество цифр в числе {number} = {colDigit}", ConsoleColor.DarkGreen);
