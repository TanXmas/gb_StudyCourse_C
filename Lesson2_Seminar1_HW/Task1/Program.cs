//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
	Console.WriteLine($"max = {number1}, min = {number2}");
else
	if (number2 > number1)
		Console.WriteLine($"max = {number2}, min = {number1}");
	else
		Console.WriteLine("Числа равны");
