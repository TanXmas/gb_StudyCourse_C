/* Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. */


void printArray (int[] array, int len)
{  
    Console.Write("[");
    for (int i = 0; i < len; i ++)
    {
        Console.Write($"{array[i]}");
        if (i < len-1) Console.Write(",");
    }
    Console.WriteLine("]");
}


void fillArray(int[] array, int len)
{
    for (int i = 0; i < len; i++)
        array[i] = new Random().Next(0,10);
    printArray(array, len);
}


int[] copyArray(int[] array, int len)
{
    int[] newArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}


int len = new Random().Next(1,10);
int[] array = new int[len];
fillArray(array, len);
printArray(copyArray(array, len), len);
