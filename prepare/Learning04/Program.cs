using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Jacob Wright", "Programming");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Jacob Wright", "Fractions", "S5", "1-20");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Jacob Wright", "Writing", "Persuasive Essay");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}