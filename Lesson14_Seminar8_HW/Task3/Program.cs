/* Задача 58: Задайте две матрицы. 
   Напишите программу, которая будет находить произведение двух матриц. */

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


void multiply2DArray(int[,] arrayA, int[,] arrayB)
{
    int rA = arrayA.GetLength(0);
    int cA = arrayA.GetLength(1);
    int rB = arrayB.GetLength(0);
    int cB = arrayB.GetLength(1);
    if (cA != rB)
        Console.WriteLine("Невозможно найти произведение матриц.");
    else
    {
        int item = 0;
        int[,] multArray = new int[rA, cB];
        for (int i = 0; i < rA; i++)
            {
                for (int j = 0; j < cB; j++)
                {
                    item = 0;
                    for (int k = 0; k < cA; k++)
                        item += arrayA[i, k] * arrayB[k, j];
                    multArray[i, j] = item;
                }
            }
        print2DArray(multArray);
    }
}


int size_min = 2;
int size_max = 3;
int[,] arrayA = new int[new Random().Next(size_min, size_max+1), new Random().Next(size_min, size_max+1)];
int[,] arrayB = new int[new Random().Next(size_min, size_max+1), new Random().Next(size_min, size_max+1)];
fill2DArray(arrayA);
print2DArray(arrayA);
fill2DArray(arrayB);
print2DArray(arrayB);
multiply2DArray(arrayA, arrayB);
