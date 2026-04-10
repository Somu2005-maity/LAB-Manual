using System;

// Interface for checking pass status
public interface IPassCriteria
{
    bool Pass(int mark);
}

// Interface for determining division
public interface IDivisionCriteria
{
    string Division(int average);
}

// Class implementing both interfaces
public class StudentResult : IPassCriteria, IDivisionCriteria
{
    // Returns true if mark is 50 or above, otherwise false
    public bool Pass(int mark)
    {
        return mark >= 50;
    }

    // Returns a string representation of the division based on average
    public string Division(int average)
    {
        if (average >= 80)
            return "First Division";
        else if (average >= 60)
            return "Second Division";
        else if (average >= 50)
            return "Third Division";
        else
            return "No Division";
    }
}

class Program
{
    static void Main()
    {
        StudentResult student = new StudentResult();
        int mark = 65;

        Console.WriteLine($"Mark: {mark}");
        Console.WriteLine($"Pass Status: {student.Pass(mark)}");
        Console.WriteLine($"Division: {student.Division(mark)}");
    }
}
