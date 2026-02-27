using System;

class PalindromeString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string lowerInput = input.ToLower();
        char[] charArray = lowerInput.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        if (lowerInput == reversed)
        {
            Console.WriteLine($"\"{input}\" is a palindrome.");
        }
        else
        {
            Console.WriteLine($"\"{input}\" is not a palindrome.");
        }
    }
}