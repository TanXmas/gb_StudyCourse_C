// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

void CheckingMultiplicity (int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        Console.WriteLine($"Число {num1} кратно {num2}.");
    }
    else
    {
        Console.WriteLine($"Число {num1} не кратно {num2}, остаток {num1 % num2}.");
    }
}   

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

CheckingMultiplicity(number1,number2);

