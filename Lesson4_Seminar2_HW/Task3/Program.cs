/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int getNumberDayOfWeek(int numberDayOfWeek)
{
    while (numberDayOfWeek < 1 | numberDayOfWeek > 7)
    {
        Console.Write("Введите номер дня недели: ");
        numberDayOfWeek = Convert.ToInt32(Console.ReadLine());    
    }
    return numberDayOfWeek;
}

int numberDayOfWeek = 0;
numberDayOfWeek = getNumberDayOfWeek(numberDayOfWeek);

if (numberDayOfWeek < 6)
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Да");
}