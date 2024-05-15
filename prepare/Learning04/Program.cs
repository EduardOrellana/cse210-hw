using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment test = new Assignment("Samuel Bennet", "Multiplication");

        // Console.WriteLine(test.GetSummary());


        // MathAssignment test = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-9");

        // Console.WriteLine(test.GetSummary());
        // Console.WriteLine(test.GetHomeworkList());

        WritingAssignment test = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(test.GetSummary());
        Console.WriteLine(test.GetWritingInformation());


    }
}