using System;

class Program
{
    static void Main()
    {
        string correctUser = "admin";
        string correctPass = "1234";
        int attempts = 3;

        while (attempts > 0)
        {
            Console.Write("Enter Username: ");
            string user = Console.ReadLine();

            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();

            if (user == correctUser && pass == correctPass)
            {
                Console.WriteLine("Login Successful!");
                return;
            }
            else
            {
                attempts--;
                Console.WriteLine("Invalid Credentials. Attempts left: " + attempts);
            }
        }

        Console.WriteLine("Account Locked!");
    }
}