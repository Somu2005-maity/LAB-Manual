using System;

class Program
{
    static void Main()
    {
        int correctPin = 1234;
        double balance = 10000;

        Console.Write("Enter PIN: ");
        int pin = Convert.ToInt32(Console.ReadLine());

        if (pin == correctPin)
        {
            Console.Write("Enter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrawal Successful!");
                Console.WriteLine("Remaining Balance = ₹" + balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance!");
            }
        }
        else
        {
            Console.WriteLine("Invalid PIN!");
        }
    }
}