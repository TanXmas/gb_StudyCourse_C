/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
    [3 7 22 2 78] -> 76 */


void printArray(double[] array, int len)
{
    Console.Write("[");
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]}");
        if (i < len - 1) Console.Write("  ");
    }
    Console.WriteLine("]");
}


void fillArray(double[] array, int len)
{
    for (int i = 0; i < len; i++)
        array[i] = Math.Round(new Random().NextDouble()*100, 1);
    printArray(array, len);
}


void getDifBetweenMaxAndMinInArray(double[] array, int len)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < len; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементом массива равна {max - min}");
}


int len = new Random().Next(2,11);
double[] array = new double[len];
fillArray(array, len);
getDifBetweenMaxAndMinInArray(array, len);
