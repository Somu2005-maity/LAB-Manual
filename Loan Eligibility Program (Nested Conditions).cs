using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Monthly Income: ");
        double income = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Credit Score: ");
        int creditScore = Convert.ToInt32(Console.ReadLine());

        if (age >= 21 && age <= 60)
        {
            if (income >= 25000)
            {
                if (creditScore >= 700)
                    Console.WriteLine("Loan Approved ✅");
                else
                    Console.WriteLine("Loan Rejected: Low Credit Score");
            }
            else
                Console.WriteLine("Loan Rejected: Insufficient Income");
        }
        else
            Console.WriteLine("Loan Rejected: Age Criteria Not Met");
    }
}