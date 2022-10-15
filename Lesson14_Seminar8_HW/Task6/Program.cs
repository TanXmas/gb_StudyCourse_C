/* Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника */


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


int getFactorial(int number)
{
    int fact = 1;
    for (int i = 2; i <= number; i++)
        fact *= i;
    return fact;
}


void printArray(string[] array)
{
    foreach (string item in array)
        Console.WriteLine(item);
}


void fillTriangular(string[] triangular)
{
    int num = triangular.Length;
    for (int i = num-1; i >= 0; i--)
    {
        for (int c = 0; c <= i; c++)
        {
            triangular[i] += (getFactorial(i) / (getFactorial(c) * getFactorial(i - c))) + " ";
        }
        int len = triangular[num-1].Length;  
        int wspace = (len - triangular[i].Length)/2 + triangular[i].Length;
        triangular[i] = triangular[i].PadLeft(wspace);
    }
}


int num = getNumberFromUser("Введите натуральное число: ");
string[] triangular = new string[num];

fillTriangular(triangular);
printArray(triangular);
