/* Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
   Найдите сумму отрицательных и положительных элементов массива.
   Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20. */


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


void getSumDigits(int[] array, int len)
{
    int sumNegative = 0;
    int sumPositive = 0;
    for (int i = 0; i < len; i ++)
    {
        if (array[i] < 0) 
            sumNegative += array[i];
        else
            sumPositive += array[i];
    }
    Console.WriteLine($"Сумма положительных чисел равна {sumPositive}");
    Console.WriteLine($"Сумма отрицательных чисел равна {sumNegative}");
}

int len = 12;
int[] array = new int[len];
fillArray(array, len);
getSumDigits(array, len);
