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
        ScriptureBox boxScripture = new ScriptureBox();

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue; //just to be funny :)

        while (choice != 5)
        {
            Console.WriteLine("\nWelcome! to this program, you can choose this options: \n1)Random Scripture.\n2)Add one Scripture.\n3)View Scriptures.\n4)Select One Scripture.\n5).\n");

            string stringChoice = Console.ReadLine();
            bool validator = int.TryParse(stringChoice, out number);

            if (stringChoice == "" || (!validator)) //We are ensuring that the user only will put one number.
            {
                choice = 0;
            }
            else {
                choice = int.Parse(stringChoice);
            }
            Console.Clear();
            switch (choice)
            {
                case 1:

                    //Random Scripture will be printed.
                    Scripture scripture = boxScripture.randomScripture();

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

                        Console.WriteLine($"\nThis is the Scripture: \n{myScripture.GetDisplayText()}");

                        boxScripture.AddScripture(myScripture);//calling a new ScriptureBox and add the new Scritpure.

                    }
                    else
                    {
                        Console.WriteLine("\nInsert the scripture 'just the text'");
                        string newScriptureText = Console.ReadLine();

                        //Adding the scripture.
                        Scripture myScripture = new Scripture(new Reference(newBook, chapterNewBook, verseNewBook), newScriptureText);

                        boxScripture.AddScripture(myScripture);//calling a new ScriptureBox and add the new Scritpure.
                    }
                    break; //break of the case 2

                case 3:
                    boxScripture.printScriptures();
                    break;

                case 4:
                    //this case will present one specific scripture.
                    //Local Variable.

                    int scriptureSelectedIndex;

                    Console.WriteLine("What Scripture do you want to memorize?");

                    string strincScriptureSelected = Console.ReadLine();

                    bool validatorScriptureSelected = int.TryParse(strincScriptureSelected, out number);

                    if (strincScriptureSelected == "" || (!validatorScriptureSelected)) //We are ensuring that the user only will put one number.
                    {
                        scriptureSelectedIndex = 0;
                    }
                    else {
                        scriptureSelectedIndex = int.Parse(strincScriptureSelected);
                    }
                    
                    //call the class Scritpure with the scriptureSelected variable the number of the index that the User is providing us.
                    Scripture scriptureSelected = boxScripture.scriptureSelected(scriptureSelectedIndex - 1);//-1 beacuse then index always start with 0

                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine(scriptureSelected.GetDisplayText());
                        
                        Console.WriteLine("\nPress enter to continue or type 'quite' to finish");

                        toQuite = Console.ReadLine();
                        Console.Clear();

                        if (toQuite != "quite")
                        {
                            scriptureSelected.HideRandomWords(1);
                        }

                        if (scriptureSelected.IsCompletelyHidden())
                        {
                            Console.WriteLine("try to memorize!");
                            break;
                        }
            
                    }while (toQuite != "quite");

                        choice = 0;
                    break; //break of the case 4

                case 5:
                    break;
            }
        }
    Console.ResetColor(); //return the normal color.

    }
}