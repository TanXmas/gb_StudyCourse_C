/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int getNumberFromUser(string infoForUser)
{
    int number = 0;
    while (number == 0)
    {
        Console.Write(infoForUser);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out number);
        if (userLine == "0") break;
    }
    return number;
}


void fillArray(int[] array, string infoForUser)
{
    Console.WriteLine(infoForUser);
    int len = array.Length;
    string [] coordinate = {"x: ", "y: ", "z: "};
    for (int i = 0; i < len; i++)
        array[i] = getNumberFromUser("Введите " + coordinate[i]);
}


double getDistance(int[] a, int[] b)
{
    int len = a.Length;
    int sumOfSquares = 0;
    for (int i = 0; i < len; i++)
        sumOfSquares += (int) Math.Pow(b[i]-a[i],2);
    return Math.Sqrt(sumOfSquares);
}


int [] pointA = new int[3];
int [] pointB = new int[3];

fillArray(pointA,"Координаты для точки А");
fillArray(pointB,"Координаты для точки B");

double distance = getDistance(pointA, pointB);
Console.WriteLine($"Расстояние между точками A и В равно {Math.Round(distance,2)}.");
