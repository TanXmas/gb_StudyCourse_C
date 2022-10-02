/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0 */


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
        array[i] = new Random().Next(0, 100);
    printArray(array, len);
}


int getSumNumbersInArray(int[] array, int len)
{
    int sum = 0;
    for (int i = 1; i < len; i += 2)
        sum += array[i];
    return sum;
}


int len = new Random().Next(2,11);
int[] array = new int[len];
fillArray(array, len);
int sumNumbers = getSumNumbersInArray(array, len);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sumNumbers}.");
