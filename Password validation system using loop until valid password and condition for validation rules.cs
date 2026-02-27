using System;

class Program
{
    static void Main()
    {
        string password;
        bool isValid = false;

        while (!isValid)
        {
            Console.Write("Enter Password: ");
            password = Console.ReadLine();

            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            if (password.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters long.\n");
                continue;
            }

            foreach (char ch in password)
            {
                if (char.IsUpper(ch))
                    hasUpper = true;
                else if (char.IsLower(ch))
                    hasLower = true;
                else if (char.IsDigit(ch))
                    hasDigit = true;
            }

            if (!hasUpper)
            {
                Console.WriteLine("Password must contain at least one uppercase letter.\n");
                continue;
            }

            if (!hasLower)
            {
                Console.WriteLine("Password must contain at least one lowercase letter.\n");
                continue;
            }

            if (!hasDigit)
            {
                Console.WriteLine("Password must contain at least one digit.\n");
                continue;
            }

            isValid = true;
        }

        Console.WriteLine("Password is valid!");
    }
}
