void fillArray(int[] collection)
{
    int len = collection.Length;
    int i = 0;
    while (i < len)
    {
        collection[i] = new Random().Next(0,10);
        i += 1;
    }
}

void PrintArray (int[] collection)
{
    int len = collection.Length;
    int i = 0;
    while (i < len)
    {
        Console.Write($"{collection[i]} ");
        i += 1;
    }
    Console.WriteLine();
}

int findElem(int[] collection, int find)
{
    int len = collection.Length;
    int i = 0;
    int index = -1;
    while (i < len)
    {
        if (collection[i] == find) 
        {
            index = i;
            break;
        }
        i += 1;
    }
    return index;
}


int [] array = new int[10];
fillArray(array);
PrintArray(array);
Console.WriteLine(findElem(array,4));
