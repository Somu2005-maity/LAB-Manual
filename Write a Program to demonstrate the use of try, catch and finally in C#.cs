using System;

class ExceptionDemo
{
    static void Main()
    {
        try
        {
            // Block 1: try - Code that might throw an exception
            Console.Write("Enter a number to divide 100 by: ");
            int divisor = int.Parse(Console.ReadLine());
            
            int result = 100 / divisor;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            // Block 2: catch - Handles specific exceptions
            Console.WriteLine("Error: You cannot divide by zero.");
            Console.WriteLine($"Details: {ex.Message}");
        }
        catch (FormatException)
        {
            // Multiple catch blocks can handle different error types
            Console.WriteLine("Error: Please enter a valid numeric value.");
        }
        catch (Exception ex)
        {
            // General catch block for any other unexpected errors
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            // Block 3: finally - Code that ALWAYS executes
            // Typically used for closing files or database connections
            Console.WriteLine("Execution of try-catch-finally block is complete.");
        }
    }
}
