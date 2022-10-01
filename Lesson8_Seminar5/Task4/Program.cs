/* Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
   Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
   [5, 18, 123, 6, 2] -> 1
   [1, 2, 3, 6, 2] -> 0
   [10, 11, 12, 13, 14] -> 5 */


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
        array[i] = new Random().Next(0, 200);
    printArray(array, len);
}


int getCountNumbersInArray(int[] array, int len)
{
    int count = 0;
    for (int i = 0; i < len; i++)
        if (array[i] >= 10 && array[i] <= 99) count += 1;
    return count;
}


int len = 123;
int[] array = new int[len];
fillArray(array, len);
int countNumbers = getCountNumbersInArray(array, len);
Console.WriteLine($"Количество элементов в массиве, значения которых лежат на отрезке [10,99] = {countNumbers}");
