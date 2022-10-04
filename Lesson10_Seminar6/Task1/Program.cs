/* Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
   [1 2 3 4 5] -> [5 4 3 2 1]
   [6 7 3 6] -> [6 3 7 6] */


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


int[] reverseArray(int[] array, int len)
{
    int temp = 0;
    for (int i = 0; i < len/2; i++)
    {
        temp = array[i];
        array[i] = array[len-1-i];
        array[len-1-i] = temp;
    }
    return array;
}


int len = new Random().Next(1,10);
int[] array = new int[len];
fillArray(array, len);
reverseArray(array, len);
printArray(array, len);
