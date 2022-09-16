// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Write("Введите номер дня недели: ");
int numberDayWeek = Convert.ToInt32(Console.ReadLine());

if (numberDayWeek == 1) Console.WriteLine("Понедельник"); else
    if (numberDayWeek == 2) Console.WriteLine("Вторник"); else
        if (numberDayWeek == 3) Console.WriteLine("Среда"); else
            if (numberDayWeek == 4) Console.WriteLine("Четверг"); else
                if (numberDayWeek == 5) Console.WriteLine("Пятница"); else
                    if (numberDayWeek == 6) Console.WriteLine("Суббота"); else
                        if (numberDayWeek == 7) Console.WriteLine("Воскресенье");