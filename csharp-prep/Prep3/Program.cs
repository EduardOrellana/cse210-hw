using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!\n\n\n");


        Random randomGenerator = new Random();

        int number = randomGenerator.Next(1, 11);
        int guessNumber = -1;
        string message;
        string decisionToPlay = "yes";
        int count = 0;

        Console.Write("What is the magic number? ");
        string magicNumberFromUser = Console.ReadLine();
        int magicNumber = int.Parse(magicNumberFromUser);
        Console.Write("\n\n");

        do
        {
            Console.WriteLine("Do you want to play? (yes/not)");
            decisionToPlay = Console.ReadLine();

            while (magicNumber != guessNumber)
            {
                count++;
                Console.Write("What is your guess? ");
                string guessFromUser = Console.ReadLine();
                guessNumber = int.Parse(guessFromUser);

                if (guessNumber < magicNumber && guessNumber > (magicNumber - 5))
                {
                    message = "Higher";
                    Console.WriteLine(message);
                }
                else if (guessNumber == magicNumber)
                {
                    Console.WriteLine($"You get it! in {count} times!");
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("More Higher");
                }
                else
                {
                    message = "Lower";
                    Console.WriteLine(message);
                }
            }
        }while (decisionToPlay == "yes");


    }
}