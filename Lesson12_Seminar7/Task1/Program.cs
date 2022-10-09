/* Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */


void printArray(int[,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            Console.Write($"{array[r, c]} ");
        }
        Console.WriteLine();
    }
}


void fillArray(int[,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            array[r, c] = r + c;
        }
    }
}


int m = new Random().Next(1, 6);
int n = new Random().Next(1, 6);
Console.WriteLine($"m = {m}, n = {n}");
int[,] array = new int[m, n];
fillArray(array);
printArray(array);
