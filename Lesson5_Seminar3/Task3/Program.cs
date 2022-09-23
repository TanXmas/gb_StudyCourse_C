/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 */

double getDistance(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2));
}

int x1 = new Random().Next(-10, 11);
int y1 = new Random().Next(-10, 11);
int x2 = new Random().Next(-10, 11);
int y2 = new Random().Next(-10, 11);

double length = getDistance(x1, y1, x2, y2);
Console.WriteLine($"Между точками с координатами ({x1},{y1}) и ({x2},{y2}) равна {Math.Round(length,2)}.");
