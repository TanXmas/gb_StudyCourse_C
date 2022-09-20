/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

void getThirdDigitFromNumber(int number)
{
    int countDigit = 0;
    int numberForCount = number;
    while (numberForCount > 0)
    {
        countDigit += 1;
        numberForCount /= 10;
    }
    
    if (countDigit < 3)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        Console.WriteLine(number / (int) Math.Pow(10, countDigit-3) % 10);
    }
}

int randomNumber = new Random().Next(1, 1000000);
Console.WriteLine(randomNumber);
getThirdDigitFromNumber(randomNumber);
