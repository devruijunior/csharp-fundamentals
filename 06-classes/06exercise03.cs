using System;

class Program
{
    static void Main()
    {
        // Cria um objeto da classe Student
        Student student = new Student();

        // Solicita o nome do aluno
        Console.Write("Enter student name: ");
        student.Name = Console.ReadLine() ?? "";

        // Solicita a nota
        Console.Write("Enter student grade: ");

        // Converte a entrada para double
        double grade = double.Parse(Console.ReadLine());

        // Atribui a nota usando a propriedade Grade
        // Neste momento o SET será executado
        student.Grade = grade;

        // Exibe os dados
        Console.WriteLine();
        Console.WriteLine("Student: " + student.Name);
        Console.WriteLine("Grade: " + student.Grade);
        Console.WriteLine("Status: " + student.GetStatus());
    }
}

class Student
{
    // Campo privado
    // Somente a própria classe pode acessar diretamente
    private double grade;

    // Propriedade pública
    // É a "porta de entrada" para acessar o campo privado
    public double Grade
    {
        // Executado quando alguém lê o valor
        get
        {
            return grade;
        }

        // Executado quando alguém tenta atribuir um valor
        set
        {
            // Aceita somente notas entre 0 e 10
            if (value >= 0 && value <= 10)
            {
                grade = value;
            }
        }
    }

    // Nome continua público por enquanto
    public string Name;

    // Método responsável por determinar o status do aluno
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