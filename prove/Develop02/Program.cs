using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Blue; //just to be funny :)
        Console.WriteLine("Hello to your Journey\n");

        //main variables
        PromptGenerator prompt;
        int choice = 1;
        string anAnswer;
        DateTime theCurrentTime = DateTime.Now;
        string dateToText;
        string anPrompt;
        int number;
        bool validatorOfTheNumberFromUser; //is to vaidate that the user only can have the option to put numbers.

        
        //Starting the new Journal.
        Journal theJournal = new Journal();
        Entry anEntry;

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n6. Edit\n");
            string stringChoice = Console.ReadLine();
            validatorOfTheNumberFromUser = int.TryParse(stringChoice, out number);

            if (stringChoice == "" || (!validatorOfTheNumberFromUser)) //We are ensuring that the user only will put one number.
            {
                choice = 7;
            }
            else {
                choice = int.Parse(stringChoice);
            }
            
            switch (choice)
            {
                case 1:
                    anEntry = new Entry();
                    prompt = new PromptGenerator();

                    anPrompt = prompt.GetRandomPrompt(); //Freezing the Random Prompt
                    anEntry._promptText = anPrompt; //adding the Random Prompt

                    dateToText = theCurrentTime.ToShortDateString(); //getting the current date into string
                    anEntry._date = dateToText;

                    Console.WriteLine($"\n{anPrompt}\n");//printing the Random Prompt to the user interface

                    anAnswer = Console.ReadLine();//response from User
                    anEntry._entryText= anAnswer;

                    theJournal.AddEntry(anEntry); //add the information into the journey
                    break;

                case 2:
                    theJournal.DisplayAll();
                    break;

                case 3:
                    
                    Console.Write("\nPlease type the name of your file (with the extension (.csv or .txt)): ");
                    string nameFileLoaded = Console.ReadLine();

                    theJournal.LoadFromFile(nameFileLoaded);
                    break;

                case 4:

                    Console.WriteLine("You are going to save your prompts\n");

                    Console.Write("Please write the name that your Journey: ");
                    string nameFile = Console.ReadLine();
                    int typeFile;

                    Console.WriteLine("\nWhat do you Prefer?\n1)txt\n2)csv");
                    typeFile = int.Parse(Console.ReadLine());

                    switch (typeFile)
                    {
                        case 1:
                            theJournal.SaveToFile($"{nameFile}.txt");
                            Console.WriteLine("\nThe file was saved succesfully");
                            break;
                        case 2:
                            theJournal.SaveToFile($"{nameFile}.csv");
                            Console.WriteLine("\nThe file was saved succesfully");
                            break;
                        case >2:
                            Console.WriteLine("\nINVALID\n");
                            break;
                        case <1:
                            Console.WriteLine("\nINVALID\n");
                            break;
                    }

                    break;
                case 5:
                    break;

                case 6:
                    //To edit the responses.
                    theJournal.EditJourney();
                    break;
                
                case >6:
                    break;
            }
            
        }
        Console.WriteLine("\nThanks for your time :)");
    }
}