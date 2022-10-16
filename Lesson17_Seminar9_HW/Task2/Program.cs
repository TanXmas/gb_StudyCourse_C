/* Задача 66: Задайте значения M и N. 
   Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. */

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


int getSumNumbers(int m, int n)
{
    if (m < n)
        return m + getSumNumbers(m+1,n);
    else
        return m;
}


int m = getNumberFromUser("Введите натуральное число M: ");
int n = getNumberFromUser("Введите натуральное число N: ");

int sumNumbers = getSumNumbers(m ,n);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} = {sumNumbers}");
