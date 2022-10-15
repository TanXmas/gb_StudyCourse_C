/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
   Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. */

/*
void printArray (int[] array)
{  
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
}
*/

void mixArray(int[] array)
{
    for (int i = array.Length - 1; i >= 0; i--)
    {
        int j = new Random().Next(i);
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}


void print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }    
    }
    Console.WriteLine();
}

void fill3DArray(int[,,] array, int[] arrayRange)
{
    if (array.GetLength(0) * array.GetLength(1) * array.GetLength(2) > arrayRange.Length)
    {
        Console.WriteLine("Размер массива больше количество двузначных чисел.");
    }
    else
    {
        int index = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i,j,k] = arrayRange[index];
                    index++;
                }
            }
        }
    }
}


int[] arrayRange = Enumerable.Range(10, 90).ToArray();
mixArray(arrayRange);
//printArray(arrayRange);

int size1 = new Random().Next(2,3);
int size2 = new Random().Next(2,3);
int size3 = new Random().Next(2,3);
int[,,] array = new int[size1, size2, size3];
fill3DArray(array, arrayRange);
print3DArray(array);
