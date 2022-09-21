/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

void getThirdDigitFromNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет.");
    }
    else
    {
        while (number > 1000)
        {
            number /= 10;
        }
        Console.WriteLine($"Третья цифра: {number % 10}.");
    }
}

int randomNumber = new Random().Next(1, 1000);
Console.WriteLine($"Случайное число: {randomNumber}.");
getThirdDigitFromNumber(randomNumber);
