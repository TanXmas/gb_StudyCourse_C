/* Задайте двумерный массив из целых чисел. 
   Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. */

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


int[] getAddressMinNumber(int[,] array)
//void getAddressMinNumber(int[,] array)
{
    int minNumber = array[0,0];
    int[] address = {0,0};
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < minNumber)
            {
                minNumber = array[i,j];
                address[0] = i;
                address[1] = j;
            }
        }
    }
    return address;
}


int[,] delCross(int[,] array, int delRow, int delCol)
{
    int r = 0;
    int c = 0;
    int[,] truncArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    for (int i = 0; i < array.GetLength(0)-1; i++)
    {
        if (i >= delRow) r = i + 1;
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            if (j >= delCol) c = j + 1;
            truncArray[i,j] = array[r,c];
        }
    }
    return truncArray;
}



int rows = new Random().Next(2, 10);
int columns = new Random().Next(2, 10);
Console.WriteLine($"Массив {rows} х {columns}");
int[,] array = new int[rows, columns];
fillArray(array);
printArray(array);

int[] address = getAddressMinNumber(array);
Console.WriteLine($"{address[0]},{address[1]}");
int[,] truncArray = delCross(array, address[0], address[1]);
printArray(truncArray);
