using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * radius * radius;

        Console.WriteLine("Area of Circle = " + area);
    }
}
