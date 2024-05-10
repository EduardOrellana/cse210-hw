using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");
        
        //global or principal variables.
        string toQuite = "";
        int choice = 0;
        int number;

        while (choice != 4)
        {
            Console.WriteLine("\nWelcome! to this program, you can choose this options: \n1)Random Scripture.\n2)Add one Scripture.\n3)View Scriptures.\n4)Exit.\n");

            string stringChoice = Console.ReadLine();
            bool validator = int.TryParse(stringChoice, out number);

            if (stringChoice == "" || (!validator)) //We are ensuring that the user only will put one number.
            {
                choice = 0;
            }
            else {
                choice = int.Parse(stringChoice);
            }
            
            switch (choice)
            {
                case 1:

                    //Random Scripture will be printed.
                    Scripture scripture = new ScriptureBox()._randomScripture();

                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine(scripture.GetDisplayText());
                        
                        Console.WriteLine("\nPress enter to continue or type 'quite' to finish");

                        toQuite = Console.ReadLine();
                        Console.Clear();

                        if (toQuite != "quite")
                        {
                            scripture.HideRandomWords(1);
                        }

                        if (scripture.IsCompletelyHidden())
                        {
                            Console.WriteLine("try to memorize!");
                            break;
                        }
            
                }while (toQuite != "quite");

                    choice = 0;
                    break;
                
                case 2:
                    //Adding a new Scripture
                    ScriptureBox scriptureBox = new ScriptureBox(); //to call the ScriptureBox.

                    Console.WriteLine("\nBook: example: 1 Nephi");
                    string newBook = Console.ReadLine(); //The book we are adding into the ScriptureBox.

                    Console.WriteLine("\nChapter:");
                    int chapterNewBook = int.Parse(Console.ReadLine()); //The chapter of the new book.

                    Console.WriteLine("\nVerse:");
                    int verseNewBook = int.Parse(Console.ReadLine()); //The verse of the chatper of the New Book.

                    Console.WriteLine("\nIs there other verse? (yes/not)");

                    if (Console.ReadLine() == "yes") //this part the code will add other verse.
                    {
                        Console.WriteLine("\nLast Verse of the Scripture:\n");
                        int lastVerseNewBook = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nInsert the scripture 'just the text'");
                        string newScriptureText = Console.ReadLine();

                        //Adding the scripture.
                        Scripture myScripture = new Scripture(new Reference(newBook, chapterNewBook, verseNewBook, lastVerseNewBook), newScriptureText);

                        scriptureBox.AddScripture(myScripture);//calling a new ScriptureBox and add the new Scritpure.

                    }
                    else
                    {
                        Console.WriteLine("\nInsert the scripture 'just the text'");
                        string newScriptureText = Console.ReadLine();

                        //Adding the scripture.
                        Scripture myScripture = new Scripture(new Reference(newBook, chapterNewBook, verseNewBook), newScriptureText);

                        scriptureBox.AddScripture(myScripture);//calling a new ScriptureBox and add the new Scritpure.
                    }
                    break;

                    case 3:
                    {
                        new ScriptureBox().printScriptures();
                    }
                    break;
            }
        }

    }
}