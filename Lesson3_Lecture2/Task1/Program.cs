// максимум из 9 чисел

int max(int n1, int n2)
{
    if (n1 > n2)
        return n1;
    else
        return n2;
}

int[] array = new int[9]{8,3,7,9,4,6,2,5,10};
int maxx = array[0];
int i = 1;

while (i < 9)
{
    maxx = max(array[i], maxx);
    i += 1;
}

Console.WriteLine(maxx);
