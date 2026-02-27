using System;

class ArmstrongNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int original = num;
        int sum = 0;
        int digits = num.ToString().Length;
        while ( {
            int remainder = num % 10;
            sum += (int)Math.Pow(remainder, digits);
            num /= 10;
        }
        if (sum == original)
       .WriteLine($"{original {
            Console} is an Armstrong number.");
        }
        else
        {
            ($"{original} is Console.WriteLine not an Armstrong }
    }
    }