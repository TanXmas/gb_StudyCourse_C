void printArray (string[] array)
{  
    Console.Write("[");
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i]);
        if (i < array.Length-1) Console.Write(", ");
    }
    Console.WriteLine("]");
}


string[] fillArrayOut (string[] arrayIn)
{
    string[] arrayOut = new string[0];
    int j = 0;
    for (int i = 0; i < arrayIn.Length; i++)
    {
        if (arrayIn[i].Length <= 3)
        {
            Array.Resize<string>(ref arrayOut, j+1);
            arrayOut[j] = arrayIn[i];
            j++;
        }
    }
    return arrayOut;
}


string[] arrayInput = new string[]{"Hello", "world", "!", ":-)", "1234", "-2", "computer science", "RU", "Russia"};
string[] arrayOutput = fillArrayOut(arrayInput);
printArray(arrayOutput);