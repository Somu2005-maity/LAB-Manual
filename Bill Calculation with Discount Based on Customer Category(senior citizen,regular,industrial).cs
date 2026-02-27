using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter total bill amount: ");
        double bill = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter customer category (senior/regular/industrial): ");
        string category = Console.ReadLine().ToLower();

        double discount = 0;

        if (category == "senior")
            discount = bill * 0.20;
        else if (category == "regular")
            discount = bill * 0.10;
        else if (category == "industrial")
            discount = bill * 0.05;
        else
        {
            Console.WriteLine("Invalid Category");
            return;
        }

        double finalAmount = bill - discount;

        Console.WriteLine("Discount = ₹" + discount);
        Console.WriteLine("Final Bill = ₹" + finalAmount);
    }
}