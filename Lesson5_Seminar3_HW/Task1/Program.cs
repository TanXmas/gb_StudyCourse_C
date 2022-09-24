/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

int getNumberFromUser(int digitNumber)
{
    int number = 0;
    while (number == 0)
    {
        Console.Write("Введите целое пятизначное число: ");
        int.TryParse(Console.ReadLine(), out number);
        if (number != 0 && (number < (int) Math.Pow(10,digitNumber-1) | number >= (int) Math.Pow(10,digitNumber)))
            number = 0;
    }
    return number;
}


bool checkPalindrome(int number, int digitNumber)
{
    bool palindrome = true;
    while (digitNumber > 1 && palindrome)
    {
        if (number / (int) Math.Pow(10,digitNumber-1) == number % 10)
            number = number % (int) Math.Pow(10, digitNumber-1) / 10;
        else
            palindrome = false;
        digitNumber -= 2;
    }
    return palindrome;   
}


int digitNumber = 5;
int number = getNumberFromUser(digitNumber);
bool isPalindrome = checkPalindrome(number, digitNumber);

if (isPalindrome == true)
    Console.WriteLine($"Число {number} палиндромом.");
else
    Console.WriteLine($"Число {number} не палиндром.");
