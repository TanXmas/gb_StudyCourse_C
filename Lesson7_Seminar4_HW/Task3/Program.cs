/* Напишите программу, в которой пользователь задает длину массива, элементы которого задаются в диапазоне [1,99] и выводит на экран.
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33] */

int getNumberFromUser(string infoForUser)
{
    int number = 0;
    while (number == 0)
    {
        Console.Write(infoForUser);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out number);
        if (number < 0) number = 0;
    }
    return number;
}

void fillArray(int[] array, int len)
{
    for (int i = 0; i < len; i++)
        array[i] = new Random().Next(1,100);
}

void printArray (int[] array, int len)
{
    Console.Write("[");
    for (int i = 0; i < len; i ++)
    {
        Console.Write($"{array[i]}");
        if (i < len-1) Console.Write(", ");
    }
    Console.Write("]");
}

int number = getNumberFromUser("Введите натуральное число: ");
int [] array = new int[number];
fillArray(array, number);
printArray(array, number);
