using System;

class Program
{
    static void Main()
    {
        Console.Write("How many numbers do you want to add? ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter number " + i + ": ");
            int num = Convert.ToInt32(Console.ReadLine());
            sum += num;
        }

        Console.WriteLine("Sum of entered numbers = " + sum);
    }
}
