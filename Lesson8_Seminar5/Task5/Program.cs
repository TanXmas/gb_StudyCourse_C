/* Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
    [1 2 3 4 5] -> 5 8 3
    [6 7 3 6] -> 36 21 */


void printArray(int[] array, int len)
{
    Console.Write("[");
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]}");
        if (i < len - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}


void fillArray(int[] array, int len)
{
    for (int i = 0; i < len; i++)
        array[i] = new Random().Next(1, 10);
    printArray(array, len);
}


void getNewArray(int[] array, int len)
{
    int newLen = len / 2 + len % 2;
    int[] newArray = new int[newLen];
    for (int i = 0; i < len/2; i++)
        newArray[i] = array[i] * array[len-1-i];
    if (len % 2 == 1) 
        newArray[newLen-1] = array[newLen-1];
    printArray(newArray, newLen);
    
}


int len = new Random().Next(1,15);
int[] array = new int[len];
fillArray(array, len);
getNewArray(array, len);
