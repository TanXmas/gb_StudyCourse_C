/* Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива. */

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void fillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
}


int[,] swopRows(int[,] array, int irow1, int irow2)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[irow1, j];
        array[irow1,j] = array[irow2,j];
        array[irow2,j] = temp;
    }
    return array;
}


int m = new Random().Next(2, 10);
int n = new Random().Next(2, 10);
Console.WriteLine($"m = {m}, n = {n}");
int[,] array = new int[m, n];
fillArray(array);
printArray(array);
int[,] swopArray = swopRows(array, 0, array.GetLength(0)-1);
printArray(swopArray);
