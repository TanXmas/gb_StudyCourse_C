/* Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
   4; массив [6, 7, 19, 345, 3] -> нет
   -3; массив [6, 7, 19, 345, 3] -> да */


void printArray (int[] array, int len)
{   
    Console.Write("[");
    for (int i = 0; i < len; i ++)
    {
        Console.Write($"{array[i]}");
        if (i < len-1) Console.Write(",");
    }
    Console.WriteLine("]");
}


void fillArray(int[] array, int len)
{
    for (int i = 0; i < len; i++)
        array[i] = new Random().Next(0,20);
    printArray(array, len);
}


bool findNumberInArray(int[] array, int len, int userNumber)
{
    bool findNumber = false;
    for (int i = 0; i < len; i ++)
        if (array[i] == userNumber)
        {
            findNumber = true;
            break;
        }
    return findNumber;
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
    }
    return number;
}


int len = new Random().Next(1,10);
int[] array = new int[len];
fillArray(array, len);
int userNumber = getNumberFromUser("Введите натуральное число: ");
bool findNumber = findNumberInArray(array, len, userNumber);
Console.WriteLine($"Число {userNumber} {((findNumber)?"в":"не в")} массиве.");

/*
if (findNumber)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");
*/