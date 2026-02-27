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

        double SI = (P * R * T) / 100;

        Console.WriteLine("Simple Interest = " + SI);
    }
}

