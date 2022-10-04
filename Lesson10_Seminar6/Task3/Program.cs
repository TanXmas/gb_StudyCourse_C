/* Напишите программу, которая будет преобразовывать десятичное число в двоичное.
   45 -> 101101
   3 -> 11
   2 -> 10 */


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
