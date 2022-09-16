//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.Write("Введите первое целое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 == Math.Pow(userNumber2, 2))
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");