/* Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
   В случае, если это невозможно, программа должна вывести сообщение для пользователя. */

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


void turnArray(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i+1; j < array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
        }
        printArray(array);
    }
    else
    {
        Console.WriteLine("Невозможно перевернуть массив.");
    }
}


int m = new Random().Next(5, 6);
int n = new Random().Next(5, 6);
//Console.WriteLine($"m = {m}, n = {n}");
int[,] array = new int[m, n];
fillArray(array);
printArray(array);
turnArray(array);
