/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    [345, 897, 568, 234] -> 2 */


void printArray(int[] array, int len)
{
    Console.Write("[");
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]}");
        if (i < len - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}


void fillArray(int[] array, int len)
{
    for (int i = 0; i < len; i++)
        array[i] = new Random().Next(100, 1000);
    printArray(array, len);
}


int getCountEvenNumberInArray(int[] array, int len)
{
    int count = 0;
    for (int i = 0; i < len; i++)
        if (array[i] % 2 == 0) count += 1;
    return count;
}


int len = new Random().Next(10,21);
int[] array = new int[len];
fillArray(array, len);
int countEven = getCountEvenNumberInArray(array, len);
Console.WriteLine($"В массиве {countEven} чётных чисел.");
