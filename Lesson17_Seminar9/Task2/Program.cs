/* Задача 65: Задайте значения M и N. 
   Напишите программу, которая выведет все натуральные числа в промежутке от M до N. */

int getNumberFromUser(string infoForUser)
{
    int number = 0;
    while (number == 0)
    {
        Console.Write(infoForUser);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out number);
        //if (userLine == "0") break;
        if (number < 0) number = 0;
    }
    return number;
}


void getLine(int m, int n)
{
    if (n > m)
        getLine(m, n - 1);
    Console.Write(n + " ");
}


int m = getNumberFromUser("Введите натуральное число M: ");
int n = getNumberFromUser("Введите натуральное число N: ");
getLine(m, n);
