using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Principal: ");
        double P = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate: ");
        double R = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (Years): ");
        double T = Convert.ToDouble(Console.ReadLine());

        double CI = P * Math.Pow((1 + R / 100), T) - P;

        Console.WriteLine("Compound Interest = " + CI);
    }
}
