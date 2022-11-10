void printArray (string[] array)
{  
    int len = array.Length;
    int prev = -1;
    Console.Write("[");
    for (int i = 0; i < len; i ++)
    {
        if (!string.IsNullOrEmpty(array[i]))
            {
                if (prev > -1) Console.Write(", ");
                Console.Write(array[i]);
                prev = i;
            }
    }
    Console.WriteLine("]");
}


void fillArrayOut (string[] arrayIn, string[] arrayOut)
{
    for (int i = 0; i < arrayIn.Length; i++)
    {
        if (arrayIn[i].Length <= 3)
        {
            arrayOut[i] = arrayIn[i];
        }
    }
}


string[] arrayInput = new string[]{"Hello", "world", "!", ":-)", "1234", "-2", "computer science", "RU", "Russia"};
string[] arrayOutput = new string[arrayInput.Length];
fillArrayOut(arrayInput, arrayOutput);
printArray(arrayOutput);