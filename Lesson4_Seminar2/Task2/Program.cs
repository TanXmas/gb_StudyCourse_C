// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int getRandomNumberFromRange(int minb, int maxb)
{
    int res = new int();
    res = new Random().Next(minb, maxb+1);
    return res;
}

int getNewNum(int num)
{
    return num / 100 * 10 + num % 10;
}

int randNum = getRandomNumberFromRange(100,999);
Console.WriteLine($"Случайное число {randNum}.");
Console.WriteLine($"Новое число {getNewNum(randNum)}.");
