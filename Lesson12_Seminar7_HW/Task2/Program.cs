/* Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, 
   и возвращает значение этого элемента или же указание, что такого элемента нет. */

void print2DArray(int[,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            Console.Write(array[r, c] + "\t");
        }
        Console.WriteLine();
    }
}

void fill2DArray(int[,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            array[r, c] = new Random().Next(0, 100);
        }
    }
}

int getNumberFromUser(string infoForUser)
{
    int number = 0;
    while (number == 0)
    {
        Console.Write(infoForUser);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out number);
        if (userLine == "0") break;
        if (number < 0) number = 0;
    }
    return number;
}

void getValueFrom2DArrayByNumber(int[,] array, int number)
{
    int r = array.GetLength(0);
    int c = array.GetLength(1);
    if (number > r * c - 1)
        Console.WriteLine($"{number} - такого числа в массиве нет");
    else
        Console.WriteLine(array[number / c, number % c]);
}

int r = new Random().Next(2, 10);
int c = new Random().Next(2, 10);
int[,] array = new int[r, c];
fill2DArray(array);
print2DArray(array);

int number = getNumberFromUser("Введите позицию элемента в двумерном массиве: ");
getValueFrom2DArrayByNumber(array, number);
