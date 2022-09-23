/* Напишите программу, которая принимает на вход координаты точки (X и Y),
 причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка. */

int getCoordinateQuarter(int x, int y)
{
    int res = 0;
    if (x > 0 && y > 0)
        res = 1;
    else
        if (x < 0 && y > 0)
            res = 2;
        else
            if (x < 0 && y < 0)
                res = 3;
            else
                if (x > 0 && y < 0)
                    res = 4;
    return res;
}

int x = new Random().Next(-10, 11);
int y = new Random().Next(-10, 11);
int quarter = getCoordinateQuarter(x,y);

if (quarter == 0)
    Console.WriteLine($"Точка с координатами ({x},{y}) находится на оси.");
else
    Console.WriteLine($"Точка с координатами ({x},{y}) находится в {quarter} четверти.");
