using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Student student = new Student();

        Console.Write("Enter student name: ");
        student.Name = Console.ReadLine() ?? "";

        double grade;
        bool isValid;

        do
        {
            Console.Write("Enter student grade: ");
            string input = Console.ReadLine();

            isValid = double.TryParse(
                input,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out grade
            );

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Try again.");
            }

        } while (!isValid);

        student.Grade = grade;

        string status = student.GetStatus();

        Console.WriteLine("Student: " + student.Name);
        Console.WriteLine("Grade: " + student.Grade.ToString("F2"));
        Console.WriteLine("Status: " + status);
    }
}

class Student
{
    public string Name;
    public double Grade;

    public string GetStatus()
    {
        if (Grade >= 7)
        {
            return "Approved";
        }

        if (Grade >= 5)
        {
            return "Recovery";
        }

        return "Failed";
    }
}