/* Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

void fillArray(int[] collection)
{
    int len = collection.Length;
    int i = 0;
    while (i < len)
    {
        collection[i] = new Random().Next(0,2);
        i += 1;
    }
}


void printArray (int[] collection)
{
    int len = collection.Length;
    Console.Write("[");
    for (int i = 0; i < len; i ++)
    {
        Console.Write($"{collection[i]}");
        if (i < len-1) Console.Write(", ");
    }
    Console.Write("]");
}


int [] array = new int[8];
fillArray(array);
printArray(array);
