using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("—— Salary Calculator ——"); 
        Console.WriteLine("-------------------------"); 
        Console.WriteLine();

        Console.Write("Enter Employee name: ");
        string employeeName = Console.ReadLine();

        Console.Write("Enter Hours worked per week: ");
        double hoursWorked = double.Parse(Console.ReadLine());

        Console.Write("Enter Hourly rate: ");
        double hourlyRate = double.Parse(Console.ReadLine());

        Console.WriteLine();

        double weeklySalary = hoursWorked * hourlyRate;
        double monthlySalary = weeklySalary * 4;
        double yearlySalary = monthlySalary * 12;

        Console.WriteLine($"Employee: {employeeName}");
        Console.WriteLine($"Hours Worked: {hoursWorked}");
        Console.WriteLine($"Hourly Rate: {hourlyRate}");
        Console.WriteLine();

        Console.WriteLine($"Weekly salary: {weeklySalary}");
        Console.WriteLine($"Monthly salary: {monthlySalary}");
        Console.WriteLine($"Yearly salary: {yearlySalary}");
    }
}