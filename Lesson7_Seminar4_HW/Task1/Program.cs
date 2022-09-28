/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16  */

int getNumberFromUser(string infoForUser)
{
    int number = 0;
    while (number == 0)
    {
        Console.Write(infoForUser);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out number);
        if (userLine == "0") break;
    }
    return number;
}


void getPow(int number, int pow)
{
    int result = number;
    for (int i = 2; i <= pow; i++)
        result *= number; 
    Console.WriteLine($"Число {number} в степени {pow} = {result}");
}


int number = getNumberFromUser("Введите целое число: ");
int pow = getNumberFromUser("Введите степень: ");
getPow(number, pow);
