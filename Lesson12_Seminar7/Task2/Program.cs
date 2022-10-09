/* Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4 */


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
    Console.WriteLine();
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
    printArray(array);
}


void updateArray(int[,] array)
{
    for (int r = 0; r < array.GetLength(0); r+=2)
    {
        for (int c = 0; c < array.GetLength(1); c+=2)
        {
            array[r, c] = (int) Math.Pow(array[r, c],2);
        }
    }
    printArray(array);
}


int m = new Random().Next(3, 6);
int n = new Random().Next(3, 6);
Console.WriteLine($"m = {m}, n = {n}");
int[,] array = new int[m, n];
fillArray(array);
updateArray(array);
