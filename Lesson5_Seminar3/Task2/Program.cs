/* Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y) */

void getCoordinate (int quarter)
{
    if (quarter == 1)
        Console.WriteLine($"Координатная четверть {quarter}: x > 0, y > 0");
    else
        if (quarter == 2)
            Console.WriteLine($"Координатная четверть {quarter}: x < 0, y > 0");
        else
            if (quarter == 3)
                Console.WriteLine($"Координатная четверть {quarter}: x < 0, y < 0");
            else
                if (quarter == 4)
                    Console.WriteLine($"Координатная четверть {quarter}: x > 0, y < 0");
}

int quarter = new Random().Next(1, 5);
getCoordinate(quarter);
