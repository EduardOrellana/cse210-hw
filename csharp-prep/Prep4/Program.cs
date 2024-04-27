using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        int number = 1;
        
        Console.WriteLine("Enter a list of Numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string numberFromUser = Console.ReadLine();
            number = int.Parse(numberFromUser);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        double suma = numbers.Sum();
        double avg = numbers.Average();
        double larg = numbers.Max();

        List<double> minNumbers = new List<double>();
        
        //challenges

        foreach (int index in numbers)
        {
            if (index > 0)
            {
                minNumbers.Add(index);
            }

        }

        double min = minNumbers.Min();

        Console.WriteLine($"The sum is {suma}");
        Console.WriteLine($"The Average is: {avg}");
        Console.WriteLine($"The Largest number is: {larg}");
        Console.WriteLine($"The smalles positive is: {min} ");
        
        numbers.Sort();

        Console.WriteLine("Sorted List");
        foreach (int index in numbers)
        {
            Console.WriteLine(index);
        }


    }
}