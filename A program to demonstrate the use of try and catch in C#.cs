using System;

class Program
{
    static void Main()
    {
        try
        {
            // Code that might throw an exception
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter a divisor: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 / num2; // May throw DivideByZeroException
            Console.WriteLine($"Result: {result}");

            int[] numbers = { 10, 20, 30 };
            Console.WriteLine(numbers[5]); // This will throw IndexOutOfRangeException
        }
        catch (DivideByZeroException ex)
        {
            // Handles division by zero
            Console.WriteLine("Error: You cannot divide by zero.");
            Console.WriteLine($"Message: {ex.Message}");
        }
        catch (IndexOutOfRangeException ex)
        {
            // Handles accessing an invalid array index
            Console.WriteLine("Error: Array index is out of bounds.");
        }
        catch (Exception ex)
        {
            // Generic catch for any other unexpected errors
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            // Always executes, regardless of whether an exception occurred
            Console.WriteLine("Execution of try-catch block completed.");
        }
    }
}
