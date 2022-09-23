/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1, 4 */

int number = new Random().Next(1, 10);
int n = 1;

Console.WriteLine($"Случайное число {number}.");
while (n <= number)
{
    if (n > 1) Console.Write(", ");
    Console.Write($"{Math.Pow(n,2)}");
    n += 1;
}
