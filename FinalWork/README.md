# Итоговая проверочная работа

## **Задача**

### Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
*Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.*
<br>
*При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

**Примеры:** 
<br>
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
<br>
["1234", "1567", "-2", "computer science"] -> ["-2"]
<br>
["Russia", "Denmark", "Kazan"] -> []

<br>

___
<br>

Первоначальный массив **arrayInput** 

```c#
string[] arrayInput = new string[]{"Hello", "world", "!", ":-)", "1234", "-2", "computer science", "RU", "Russia"};
```

Пустой массив **arrayOutput** такой же длинны, как **arrayInput**.
```c#
string[] arrayOutput = new string[arrayInput.Length];
```

Функция заполнения **arrayOutput** из массива **arrayInput** строками, длина которых меньше либо равна 3 символа.
```c#
void fillArrayOut (string[] arrayIn, string[] arrayOut)
{
    // Цикл по строкам из первоначального массива
    for (int i = 0; i < arrayIn.Length; i++)
    {
        // Проверка длины строки
        if (arrayIn[i].Length <= 3)
        {
            arrayOut[i] = arrayIn[i];
        }
    }
}
```

Функция вывода результата в терминал.
```c#
void printArray (string[] array)
{  
    // Формат вывода как в примерах - массив в []
    Console.Write("[");
    // В переменной prev хранится индекс предыдущей не пустой строки
    int prev = -1;
    // Цикл по строкам массива
    for (int i = 0; i < array.Length; i ++)
    {
        // Проверка, что строка не пустая
        if (!string.IsNullOrEmpty(array[i]))
            {
                if (prev > -1) Console.Write(", ");
                Console.Write(array[i]);
                prev = i;
            }
    }
    Console.WriteLine("]");
}
```
