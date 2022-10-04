/* Напишите программу, которая будет преобразовывать десятичное число в двоичное.
   45 -> 101101
   3 -> 11
   2 -> 10 */

/*
string getBinaryNumber(int num)
{
    string s = "";
    while (num > 0)
    {
        s = ((num % 2 == 0) ? "0" : "1") + s;
        num /= 2;
    }
    return s;
}

int num = new Random().Next(0,10);
string binNum = getBinaryNumber(num);
Console.WriteLine($"Число {num} в двоичной системе {binNum}");
*/


void printBinaryNumber(bool[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] ? "1":"0");
    }
}

int getLen(int num)
{
    int len = 1;
    while (num > 1)
    {
        len += 1;
        num /= 2;
    }
    return len;
}


bool[] getBoolArray(int num)
{
    int len = getLen(num);
    bool[] boolArray = new bool[len];
    for (int i = 0; i < len; i++)
    {
        boolArray[len-1-i] = num % 2 != 0;
        num /= 2;
    }
    return boolArray;
}


int num = new Random().Next(0,10);
Console.Write($"Число {num} в двоичной системе: ");
printBinaryNumber(getBoolArray(num));

