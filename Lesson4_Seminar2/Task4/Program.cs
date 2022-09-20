// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

void CheckingMultiplicity (int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine($"Да");
    }
    else
    {
        Console.WriteLine($"Нет");
    }
}   

CheckingMultiplicity(number);