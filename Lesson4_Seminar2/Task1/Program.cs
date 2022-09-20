// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2
// 85 -> 8

int getRandomNumberFromRange(int minb, int maxb)
{
    int res = new int();
    res = new Random().Next(minb, maxb+1);
    return res;
}

int getMaxDigitFromNum(int num)
{
    int maxDigit = 0;
    while(num > 0)
    {
        int curDigit = num % 10;
        if (curDigit > maxDigit)
        {
            maxDigit = curDigit;
        }
        num = num / 10;
    }
    return maxDigit;
}

int randNum = getRandomNumberFromRange(10,99);
Console.Write($"Случайное число {randNum}. ");

int maxDigit = getMaxDigitFromNum(randNum);
Console.Write($"Максимальная цифра {maxDigit}.");
