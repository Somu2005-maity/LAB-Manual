using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter total units consumed: ");
        int units = Convert.ToInt32(Console.ReadLine());

        double bill = 0;

        // Slab calculation
        if (units <= 100)
        {
            bill = units * 1.5;
        }
        else if (units <= 200)
        {
            bill = (100 * 1.5) + ((units - 100) * 2.5);
        }
        else
        {
            bill = (100 * 1.5) + (100 * 2.5) + ((units - 200) * 4);
        }

        // Fixed meter charge
        bill += 50;

        // GST condition
        if (bill > 500)
        {
            double gst = bill * 0.18;
            bill += gst;
            Console.WriteLine("GST Applied (18%) = ₹" + gst);
        }

        Console.WriteLine("Total Electricity Bill = ₹" + bill);
    }
}