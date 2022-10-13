/* Составить частотный словарь элементов двумерного массива. 
   Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. */


void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}


void fillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-9, 10);
    }
}


void printDict (SortedDictionary<int, int> dict)
{
    foreach(var items in dict)
        Console.WriteLine($"{items.Key} встречается {items.Value} раз(а)");
}


void fillRateDict(int[,] array, SortedDictionary<int, int> rateDict)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (rateDict.ContainsKey(array[i, j]))
                rateDict[array[i, j]] += 1;
            else
                rateDict.Add(array[i, j], 1);
        }
    }
}


int rows = new Random().Next(2, 10);
int columns = new Random().Next(2, 10);
Console.WriteLine($"Массив {rows} х {columns}");
int[,] array = new int[rows, columns];
fillArray(array);
printArray(array);

SortedDictionary<int, int> rateDict = new SortedDictionary<int, int>();
fillRateDict(array, rateDict);
printDict(rateDict);
