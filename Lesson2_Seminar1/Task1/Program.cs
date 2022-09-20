// Напишите программу, которая на вход принимает число и выдает его квадрат.

Console.Write("Введите целое число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Квадрат числа {userNumber} равен {Math.Pow(userNumber, 2)}");
