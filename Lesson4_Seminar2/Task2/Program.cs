// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int getNewNum(int num)
{
    return num / 100 * 10 + num % 10;
}

int randNum = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число {randNum}.");
Console.WriteLine($"Новое число {getNewNum(randNum)}.");
