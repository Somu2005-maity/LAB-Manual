using System;

// 1. Interface Exam with method Pass (returns bool)
public interface IExam
{
    bool Pass(int mark);
}

// 2. Interface Classify with method Division (returns String)
public interface IClassify
{
    string Division(int average);
}

// 3. Class Result implementing both interfaces
public class Result : IExam, IClassify
{
    // Implementation of Pass method
    // Returns true if mark >= 50, otherwise false
    public bool Pass(int mark)
    {
        return mark >= 50;
    }

    // Implementation of Division method
    // Returns "First", "Second", or "No division" based on average
    public string Division(int average)
    {
        if (average >= 60)
        {
            return "First";
        }
        else if (average >= 50)
        {
            return "Second";
        }
        else
        {
            return "No division";
        }
    }
}

// Demonstration
class Program
{
    static void Main()
    {
        Result studentResult = new Result();
        
        // Testing Pass method
        int studentMark = 55;
        Console.WriteLine($"Mark {studentMark} - Pass: {studentResult.Pass(studentMark)}");

        // Testing Division method
        int studentAverage = 65;
        Console.WriteLine($"Average {studentAverage} - Division: {studentResult.Division(studentAverage)}");
    }
}
