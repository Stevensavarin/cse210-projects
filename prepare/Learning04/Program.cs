using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Steven Savarin", "Languages");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();

        MathAssignment a2 = new MathAssignment("Steven Savarin", "Math", "Multiplication", "12 x 12 = ?");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment a3 = new WritingAssignment("Steven Savarin", "Geography", "The Capital of Venezuela");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWrittingInformation());
        Console.WriteLine();
    }
}