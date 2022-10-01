/* Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
   [-4, -8, 8, 2] -> [4, 8, -8, -2] */


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
        array[i] = new Random().Next(-9,10);
    printArray(array, len);
}


void replaceNumbersInArray(int[] array, int len)
{
    for (int i = 0; i < len; i ++)
        array[i] *= -1;
    printArray(array, len);
}


int len = 12;
int[] array = new int[len];
fillArray(array, len);
replaceNumbersInArray(array, len);
