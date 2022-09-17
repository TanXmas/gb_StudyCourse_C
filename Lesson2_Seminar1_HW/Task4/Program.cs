//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
string answer = "";
int n = 2;

while (n <= number)
{
    if (n > 2) answer += ", ";
    answer += n;
    n += 2;
}

Console.WriteLine(answer);
