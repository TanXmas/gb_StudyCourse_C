/* Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
   N = 5 -> 0 1 1 2 3
   N = 3 -> 0 1 1
   N = 7 -> 0 1 1 2 3 5 8 */


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


int[] fillFibonacci(int[] array, int num)
{
    int i = 0;
    int fib = 0;
    int f2 = 0;
    int f1 = 0;
    while (i < num)
    {
        if (fib == 0)
        {
            array[i] = fib;
            f1 = 1;
            fib = 1;
            i += 1;
        }
        else
        {
            array[i] = fib;
            fib = f2 + f1;
            f2 = f1;
            f1 = fib;
            i += 1;
        }

    }
    return array;
}


int num = new Random().Next(0,10);
Console.WriteLine($"N = {num}");
int[] fibArray = new int[num];
printArray(fillFibonacci(fibArray, num), num);
