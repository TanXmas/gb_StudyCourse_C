/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
   0, 7, 8, -2, -2 -> 2
   -1, -7, 567, 89, 223-> 3 */


int getNumberFromUser(string infoForUser)
{
    int number = 0;
    while (number == 0)
    {
        Console.Write(infoForUser);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out number);
        if (userLine == "0")
            break;
    }
    return number;
}


void fillArray(int[] array, int len)
{
    for (int i = 0; i < len; i++)
        array[i] = getNumberFromUser($"Введите {i+1}-е целое число: ");
}


int getCountPositiveNumbers(int[] array)
{
    int len = array.Length;
    int count = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i] > 0)
            count += 1;
    }
    return count;
}


int m = Math.Abs(getNumberFromUser("Введите количество чисел: "));
int[] array = new int[m];
fillArray(array, m);
int countPositive = getCountPositiveNumbers(array);
Console.WriteLine($"Количество чисел больше 0: {countPositive}");
