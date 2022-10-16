/* Задача 64: Задайте значение N. 
   Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии. */

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
    Console.Write(n + " ");
    if (n > 1)
        getLine(n-1);
    
}  


int n = getNumberFromUser("Введите натуральное число: ");
getLine(n);
