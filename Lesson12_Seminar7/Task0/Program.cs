int[,] generateTwoDArray(int height, int widht)
{
    int[,] array = new int[height, widht];
    for (int r = 0; r < height; r++)
    {
        for (int c = 0; c < widht; c++)
        {
            array[r, c] = new Random().Next(-99, 100);
        }
    }
    return array;
}


void printWithColor(string value, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(value);
    Console.ResetColor();
}


void printTwoDArray(int[,] array)
{
    Console.Write("\t");
    for (int c = 0; c < array.GetLength(1); c++)
    {
        printWithColor(c + "\t", ConsoleColor.Green);
    }
    Console.WriteLine();
    for (int r = 0; r < array.GetLength(0); r++)
    {
        printWithColor(r + "\t", ConsoleColor.Green);
        for (int c = 0; c < array.GetLength(1); c++)
        {
            Console.Write(array[r,c] + "\t");
        }
        Console.WriteLine();
    }
}


int[,] twoDArray = generateTwoDArray(5,5);
printTwoDArray(twoDArray);
