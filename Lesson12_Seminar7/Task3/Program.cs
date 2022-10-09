/* Задайте двумерный массив. Найдите Сумма элементов главной диагонали.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */


void printArray(int[,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            Console.Write(array[r, c]  + "\t");
        }
        Console.WriteLine();
    }
    //Console.WriteLine();
}


void fillArray(int[,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            array[r, c] = new Random().Next(0, 100);
        }
    }
    printArray(array);
}


void getSumDiagonalArray(int[,] array)
{
    int sum = 0;
    int len = Math.Min(array.GetLength(0),array.GetLength(1));
    Console.Write("Сумма элементов главной диагонали: ");
    for (int i = 0; i < len; i++)
    {
        sum += array[i, i];
        Console.Write($"{array[i, i]} ");
        if (i < len - 1)
            Console.Write($"+ ");
        else
            Console.Write($"= ");
    }
    Console.Write($"{sum}");
}


int r = new Random().Next(2, 10);
int c = new Random().Next(2, 10);
int[,] array = new int[r, c];
fillArray(array);
getSumDiagonalArray(array);
