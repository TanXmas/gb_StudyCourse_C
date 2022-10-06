/* Напишите программу, которая найдёт точку пересечения двух прямых, 
   заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
   значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


double getNumberFromUser(string infoForUser)
{
    double number = 0;
    while (number == 0)
    {
        Console.Write(infoForUser);
        string userLine = Console.ReadLine();
        double.TryParse(userLine, out number);
        if (userLine == "0")
            break;
    }
    return number;
}


void getPoint(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
        Console.WriteLine($"Прямые y={k1}х+{b1} и y={k2}х+{b2} параллельны.");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Прямые {k1}х+{b1} и {k2}х+{b2} пересекаются в точке ({x} ; {y}).");
    }
}


double k1 = getNumberFromUser("k1 = ");
double b1 = getNumberFromUser("b1 = ");
double k2 = getNumberFromUser("k2 = ");
double b2 = getNumberFromUser("b2 = ");
getPoint(k1, b1, k2, b2);
