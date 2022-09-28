/* Напишите программу, котрая принимает на вход число (А) и выдает сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */


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
        //Console.Write("Введите целое положительное число: ");
        printWithColor("Введите целое положительное число: ", ConsoleColor.DarkBlue);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out number);
        if (number < 0) number = 0;
    }
    return number;
}


int getSumOrRange(int number)
{
    int summ = 0;
    for (int i = 1; i <= number; i++)
        summ += i;
    return summ;
}


int number = getNumberFromUser();
int sumNumber = getSumOrRange(number);
//Console.WriteLine(sumNumber);
printWithColor($"Сумма чисел от 1 до {number}: {sumNumber}", ConsoleColor.DarkGreen);
