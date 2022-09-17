// поиск элемента

int[] array = {1,5,0,9,2,4,3,6,4,8,7};

int n = array.Length;
int find = 4;
int i = 0;

while (i < n)
{
    if (array[i] == find) 
    {
        Console.WriteLine(i);
        break;
    }
    i += 1;
}
