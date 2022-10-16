/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
   Даны два неотрицательных числа m и n. */

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


int getAckermann(int num, int arg)
{
    int ackNum;
    if (num == 0)
        return arg + 1;
    else
        if ((num != 0) && (arg == 0))
            return getAckermann(num - 1, 1);
        else
            return getAckermann(num - 1, getAckermann(num, arg - 1));
}


int m = getNumberFromUser("Введите натуральное число M: ");
int n = getNumberFromUser("Введите натуральное число N: ");

int ackNum = getAckermann(m, n);
Console.WriteLine($"A({m},{n}) = {ackNum}");
