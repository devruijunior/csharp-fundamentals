using System;

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.Name = "Rui Junior";
        student.Grade = 8.2;

        string status = student.GetStatus();

        Console.WriteLine("Student: " + student.Name);
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