using System;

class Program
{
    static void Main()
    {
        Student student = new Student("John", 8 );

        Console.WriteLine("Student: " + student.Name);


        Console.WriteLine("Grade: " + student.Grade);

        Console.WriteLine("Status: " + student.GetStatus());
    }
}

class Student
{
    public string Name;

    public double Grade;

    public Student(string name, double grade)
    {
        Name = name;
        Grade = grade;
    }
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