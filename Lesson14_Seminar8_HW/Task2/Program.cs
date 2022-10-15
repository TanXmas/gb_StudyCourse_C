/* Задача 56: Задайте прямоугольный двумерный массив. 
   Напишите программу, которая будет находить строку с наименьшей суммой элементов. */

void print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}


void fill2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
    }
}


int getIndexRowWithMinSum(int[,] array)
{
    int minSum = 0;
    int irow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0) minSum += array[i,j];
            rowSum += array[i,j];
        }
        if (rowSum < minSum)
        {
            minSum = rowSum;
            irow = i;
        }
    }
    return irow;
}


int rows = new Random().Next(2, 10);
int columns = new Random().Next(2, 10);
Console.WriteLine($"Массив {rows} х {columns}");
int[,] array = new int[rows, columns];
fill2DArray(array);
print2DArray(array);

int indexRow = getIndexRowWithMinSum(array);
Console.WriteLine($"{indexRow+1} строка с наименьшей суммой элементов.");
