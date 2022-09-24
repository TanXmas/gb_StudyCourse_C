/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

int getNumberFromUser()
{
    int number = 0;
    while (number == 0)
    {
        Console.Write("Введите целое положительное число: ");
        int.TryParse(Console.ReadLine(), out number);
        if (number != 0 && number < 0)
            number = 0;
    }
    return number;
}


void fillArray(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
        array[i] = (int) Math.Pow(i+1,3);
}


void printArray (int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        if (i > 0) Console.Write(", ");
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}


int size = getNumberFromUser();
int [] array = new int[size];
fillArray(array);
printArray(array);
