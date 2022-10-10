/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */


void print2DArray(double[,] array)
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


void fill2DArray(double[,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            array[r, c] = Math.Round(new Random().NextDouble()*10, 1);
        }
    }
}


int m = new Random().Next(1, 6);
int n = new Random().Next(1, 6);
Console.WriteLine($"m = {m}, n = {n}");
double[,] array = new double[m, n];
fill2DArray(array);
print2DArray(array);
