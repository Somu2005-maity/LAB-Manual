using System;

class PalindromeCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int original = num;
        int reversed = 0;

        while (num > 0)
        {
            int remainder = num % 10;
            reversed = reversed * 10 + remainder;
            num /= 10;
        }
        if (original == reversed)
        {
            Console.WriteLine($"{original} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{original} is not a palindrome.");
        }
    }
}