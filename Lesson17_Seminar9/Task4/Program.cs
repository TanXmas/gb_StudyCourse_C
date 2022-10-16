/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
   и возводит число А в целую степень B с помощью рекурсии. */


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


int getPower(int num, int pow)
{
    if (pow == 0)
        return 1;
    else
        return getPower(num, pow-1) * num;
}


int a = getNumberFromUser("Введите натуральное число: ");
int b = getNumberFromUser("Введите степень: ");

int power = getPower(a,b);
Console.WriteLine($"{a}^{b} = {power}");
