using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine();

        //Assignaments:

        /*

        */

        string letter;

        Console.WriteLine("What is your grade percentage");
        string gradeFromUser = Console.ReadLine();

        int grade = int.Parse(gradeFromUser);

        if (grade >= 90 && grade >= 97)
        {
            letter = "A";
            Console.WriteLine($"Congrats! your grade is {letter} and your grade is {grade}");
        }
        else if (grade >= 90 && grade < 97)
        {
            letter = "A-";
            Console.WriteLine($"Congrats! your grade is {letter} and your score is {grade}");

        }
        else if (grade >= 80)
        {
            letter = "B";
            Console.WriteLine($"Your grade is {letter} is a good grade!");
        }
        else if (grade >= 70)
        {
            letter = "C";
            Console.WriteLine($"Your grade is {letter} is a good grade!");
        }
        else if (grade >=60)
        {
            letter = "D";
            Console.WriteLine($"Your grade is {letter} nice job");
        }
        else 
        {
            letter = "F";
            Console.WriteLine($"Sadly your grade is {letter} take other opportunity to improve your average");
        }
    }
}