using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int min = (num1 < num2) 
                    ? (num1 < num3 ? num1 : num3) 
                    : (num2 < num3 ? num2 : num3);

        Console.WriteLine("Minimum number = " + min);
    }
}
