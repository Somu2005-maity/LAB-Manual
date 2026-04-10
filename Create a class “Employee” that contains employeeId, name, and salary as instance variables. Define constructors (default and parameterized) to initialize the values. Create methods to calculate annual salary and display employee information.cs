using System;

public class Employee
{
    // Instance variables (Fields)
    private int employeeId;
    private string name;
    private double salary;

    // Default Constructor
    public Employee()
    {
        employeeId = 0;
        name = "Unknown";
        salary = 0.0;
    }

    // Parameterized Constructor
    public Employee(int id, string empName, double empSalary)
    {
        this.employeeId = id; // "this" refers to instance variables
        this.name = empName;
        this.salary = empSalary;
    }

    // Method to calculate annual salary
    public double CalculateAnnualSalary()
    {
        return salary * 12;
    }

    // Method to display employee information
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("----- Employee Details -----");
        Console.WriteLine($"ID: {employeeId}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Monthly Salary: ${salary:F2}");
        Console.WriteLine($"Annual Salary: ${CalculateAnnualSalary():F2}");
    }
}

// Example usage
class Program
{
    static void Main()
    {
        // Using default constructor
        Employee emp1 = new Employee();
        emp1.DisplayEmployeeDetails();

        // Using parameterized constructor
        Employee emp2 = new Employee(101, "Alice Johnson", 4500.50);
        emp2.DisplayEmployeeDetails();
    }
}
