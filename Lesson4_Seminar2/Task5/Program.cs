// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да 
//-4, 16 -> да 
// 25, 5 -> да
// 8,9 -> нет

void CheckSquare(int num1, int num2)
{
    if (num1 == Math.Pow(num2, 2) | num2 == Math.Pow(num1, 2))
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

CheckSquare(number1,number2);
