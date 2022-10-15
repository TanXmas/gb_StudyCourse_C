/* Задача 54: Задайте двумерный массив. 
   Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. */


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
            array[i, j] = new Random().Next(-9, 10);
    }
}


int[] sortRowFromArray(int[] row)
{
    for (int i = 1; i < row.Length; i++)
    {
        int num = row[i];
        int j = i - 1;
        while (j >= 0 && row[j] > num)
        {
            row[j + 1] = row[j];
            row[j] = num;
            j--;
        }
    }
    return row;
}


int[,] getArrayWithSortedRow(int[,] array)
{
    int[,] arrayWithSortedRow = new int[array.GetLength(0), array.GetLength(1)];
    int[] row = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            row[j] = array[i, j];
        
        int[] sortedRow = sortRowFromArray(row);
        for (int j = 0; j < sortedRow.Length; j++)
            arrayWithSortedRow[i,j] = sortedRow[j];
    }
    return arrayWithSortedRow;
}


int rows = new Random().Next(2, 10);
int columns = new Random().Next(2, 10);
Console.WriteLine($"Массив {rows} х {columns}");
int[,] array = new int[rows, columns];
fill2DArray(array);
print2DArray(array);

int[,] arrayWithSortedRow = getArrayWithSortedRow(array);
print2DArray(arrayWithSortedRow);
