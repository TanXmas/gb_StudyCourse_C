int getFibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return getFibonacci(n-1) + getFibonacci(n - 2);
}


int num = new Random().Next(1,10);
int fib = getFibonacci(num);
Console.WriteLine($"f({num}) = {fib}");
