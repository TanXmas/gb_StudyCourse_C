/* Задача 63: Задайте значение N. 
   Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. */

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


void getLine(int n)
{
    if (n > 1)
        getLine(n-1);
    Console.Write(n + " ");
}   


int n = getNumberFromUser("Введите натуральное число: ");
getLine(n);
