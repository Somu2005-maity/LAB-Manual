using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        long fact = 1;

        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }

        Console.WriteLine("Factorial = " + fact);
    }
}
