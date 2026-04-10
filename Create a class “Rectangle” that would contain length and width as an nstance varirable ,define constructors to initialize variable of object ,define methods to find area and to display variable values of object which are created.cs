using System;

public class Rectangle
{
    // Instance variables
    private double length;
    private double width;

    // Default Constructor (no parameters)
    public Rectangle()
    {
        length = 0.0;
        width = 0.0;
    }

    // Parameterized Constructor
    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    // Method to calculate and return Area
    public double FindArea()
    {
        return length * width;
    }

    // Method to display instance variables and the calculated area
    public void DisplayValues()
    {
        Console.WriteLine($"Rectangle: Length = {length}, Width = {width}, Area = {FindArea()}");
    }
}

class Program
{
    static void Main()
    {
        // Object created using Default Constructor
        Rectangle rect1 = new Rectangle();
        rect1.DisplayValues();

        // Object created using Parameterized Constructor
        Rectangle rect2 = new Rectangle(10.5, 5.2);
        rect2.DisplayValues();
    }
}
