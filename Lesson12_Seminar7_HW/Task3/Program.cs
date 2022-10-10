/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

void print2DArray(int[,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            Console.Write(array[r, c] + "\t");
        }
        Console.WriteLine();
    }
}

void fill2DArray(int[,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            array[r, c] = new Random().Next(0, 10);
        }
    }
}

void getAverageRow(int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    int sum;
    for (int r = 0; r < array.GetLength(0); r++)
    {
        sum = 0;
        for (int c = 0; c < array.GetLength(1); c++)
        {
            sum += array[r, c];
        }
        Console.Write(Math.Round((double)sum / array.GetLength(1), 1));
        if (r < array.GetLength(0) - 1)
            Console.Write("; ");
        else
            Console.Write(".");
    }
}

int r = new Random().Next(2, 10);
int c = new Random().Next(2, 10);
int[,] array = new int[r, c];
fill2DArray(array);
print2DArray(array);
getAverageRow(array);
