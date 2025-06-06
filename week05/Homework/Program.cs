using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // Test MathAssignment class
        MathAssignment m1 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "8-19");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());

        // Test WritingAssignment class
        WritingAssignment w1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());

        
    }
}