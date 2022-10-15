/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. */


void print2DArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}


void fill2DArraySpiral(string[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int num = 1;
    int border = 1;
    int countCircle = 0;

    if (columns < rows)
        countCircle = columns / 2;
    else
        countCircle = rows / 2;


    for (int circle = 0; circle < countCircle; circle++)
    {
        // left to right
        for (int j = 0 + circle; j < columns - circle; j++)
        {
            array[rows - rows + circle, j] = (num<10 ? "0":"") + num;
            num++;
        }

        // up to down
        num--;
        for (int i = 0 + circle; i < rows - circle; i++)
        {
            array[i, columns - 1 - circle] = (num<10 ? "0":"") + num;
            num++;
        }

        //right to left
        num--;
        for (int j = columns - border; j >= 0 + circle; j--)
        {
            array[rows - 1 - circle, j] = (num<10 ? "0":"") + num;
            num++;
        }

        //down to up
        num--;
        for (int i = rows - border; i > 0 + circle; i--)
        {
            array[i, 0 + circle] = (num<10 ? "0":"") + num;
            num++;
        }
        border++;
    }
}


string[,] array = new string[4, 4];
fill2DArraySpiral(array);
print2DArray(array);
