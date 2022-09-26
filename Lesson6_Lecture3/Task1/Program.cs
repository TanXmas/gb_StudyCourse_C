/*
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
*/

/*
Дан текст. В тексте нужно все пробелы заменить черточками,
маленькие буквы “к” заменить большими “К”, а большие “С” заменить
маленькими “с”.
*/

string replaceChar(string text, char oldChar, char newChar)
{
    string res = String.Empty;
    int len = text.Length;
    for (int i = 0; i < len; i ++)
    {
        if (text[i] == oldChar)
            res += $"{newChar}";
        else
            res += $"{text[i]}";
    }
    return res;
}


string text = "— Я думаю, — сказал князь, улыбаясь, — что, " +
              "ежели бы вас послали вместо нашего милого " +
              "Винценгероде, вы бы взяли приступом согласие " +
              "прусского короля. Вы так красноречивы. Вы " +
              "дадите мне чаю?";

string rep1 = replaceChar(text, ' ', '_');
Console.WriteLine(rep1);

string rep2 = replaceChar(rep1, 'к', 'К');
Console.WriteLine(rep2);

string rep3 = replaceChar(rep2, 'В', 'в');
Console.WriteLine(rep3);
