/*  */

void printMatrix(int[,] matrix)
{
    for (int r = 0; r < matrix.GetLength(0); r++)
    {
        for (int c = 0; c < matrix.GetLength(1); c++)
        {
            Console.Write($"{matrix[r,c]} ");
        }
        Console.WriteLine();
    }
}


void fillMatrix(int[,] matrix)
{
    for (int r = 0; r < matrix.GetLength(0); r++)
    {
        for (int c = 0; c < matrix.GetLength(1); c++)
        {
            matrix[r,c] = new Random().Next(1,10);
        }
    }
}


int r = new Random().Next(2,11);
int c = new Random().Next(2,11);
int[,] matrix = new int[r,c];
fillMatrix(matrix);
printMatrix(matrix);

