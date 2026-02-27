using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 12)
            Console.WriteLine("You are a Kid");
        else if (age >= 12 && age <= 17)
            Console.WriteLine("You are a Teenager");
        else if (age >= 18 && age <= 60)
            Console.WriteLine("You are an Adult");
        else
            Console.WriteLine("You are a Senior Citizen");
    }
}
