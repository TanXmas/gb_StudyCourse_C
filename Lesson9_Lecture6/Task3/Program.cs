int getFactorial(int n)
{
    if (n == 0) 
        return 1;
    else 
        return n * getFactorial(n-1);

}


int num = new Random().Next(0,17);
int fact = getFactorial(num);
Console.WriteLine($"{num}! = {fact}");
