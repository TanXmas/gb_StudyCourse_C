/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

void getThirdDigitFromNumber(int number)
{
    while (number > Math.Pow(10,3))
    {
        number /= 10;
    }
    
    if (number < Math.Pow(10,2))
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        Console.WriteLine(number % 10);
    }
}

int randomNumber = new Random().Next(1, 10000);
Console.WriteLine(randomNumber);
getThirdDigitFromNumber(randomNumber);
