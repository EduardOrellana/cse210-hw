using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Hello World");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your number: ");
        string numberFromUser = Console.ReadLine();
        int numberUser = int.Parse(numberFromUser);

        return numberUser;
    }

    static int SquareNumber(int number)
    {
        int Square = number * number;
        return Square;
    }

    static void DisplayResult(int number, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();


        string userName = PromptUserName();
        int userNUmber = PromptUserNumber();

        int squareNumber = SquareNumber(userNUmber);

        DisplayResult(squareNumber, userName);

    }
}