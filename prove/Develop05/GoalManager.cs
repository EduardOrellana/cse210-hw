using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel;
using System.Text.Json.Nodes;

public class GoalManager
{
    private List<Goal> _goalsList = new List<Goal>();
    private int _score;
    private string _nameUser;

    public GoalManager(string name)//Simple Constructor
    {
        _nameUser = name;
        _score = 0;
    }

    public void Start()
    {   //this method only print the menu

        Console.WriteLine("\nMenu Options");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List of Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record an Event");
        Console.WriteLine("6. Exit\n");

    }

    public void DisplayPlayerInfo()
    {
        //This function will print the name of the user and his/her goals.
        Console.WriteLine($"Total Score: {_score}");
    }

    public void ListGoalNames()
    {
        //This method will print just the names will be used to, edit, delete or create an Event.
        Console.WriteLine("The goals are: ");

        int count = 1;
        foreach (Goal goal in _goalsList)
        {
            Console.WriteLine($"Goal. {count}: {goal.GetStringRepresentation()}");
            count++;
        }

    }

    public void ListGoalDetails()
    {
        //This method will print the details of the goal.

        Console.WriteLine("The goals are: ");

        int count = 1;
        foreach (Goal goal in _goalsList)
        {
            Console.WriteLine($"Goal.{count}: {goal.GetDetailsString()}");
            count++;
        }

    }

    public void CreateGoal()
    {
        //This method will add a new goal into the List.

        Console.WriteLine("\nThe types of Goals are: \n");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal\n");

        Console.Write("Which type of goal would you like to create? ");
        int typeGoalFromUser = int.Parse(Console.ReadLine());

        switch (typeGoalFromUser)
        {
            case 1:

                Console.Write("\nWhat is the name of your new goal? ");
                string nameNewSimpleGoal = Console.ReadLine();
                Console.Write("\nWhat is a short description? ");
                string descNewSimpleGoal = Console.ReadLine();
                Console.Write("\nHow many point do you wan to set for this goal? ");
                string pointsNewSimpleGoal = Console.ReadLine();


                SimpleGoal newSimpleGoal = new SimpleGoal(nameNewSimpleGoal, descNewSimpleGoal, pointsNewSimpleGoal, false);

                _goalsList.Add(newSimpleGoal);//adding the new goal

                break;

            case 2:

                Console.Write("\nWhat is the name of your new goal? ");
                string nameNewEternalGoal = Console.ReadLine();
                Console.Write("\nWhat is a short description? ");
                string descNewEternalGoal = Console.ReadLine();
                Console.Write("\nHow many point do you wan to set for this goal? ");
                string pointsNewEternalGoal = Console.ReadLine();


                EternalGoal newEternalGoal = new EternalGoal(nameNewEternalGoal, descNewEternalGoal, pointsNewEternalGoal);

                _goalsList.Add(newEternalGoal);//adding the new goal

                break;

            case 3:

                Console.Write("\nWhat is the name of your new goal? ");
                string nameNewChecklistGoal = Console.ReadLine();
                Console.Write("\nWhat is a short description? ");
                string descNewChecklistGoal = Console.ReadLine();
                Console.Write("\nHow many point do you wan to set for this goal? ");
                string pointsNewChecklistGoal = Console.ReadLine();
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int targetNewChecklistGoal = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times?");
                int bonusNewChecklistGoal = int.Parse(Console.ReadLine());


                ChecklistGoal newCheckListGoal = new ChecklistGoal(nameNewChecklistGoal, descNewChecklistGoal, pointsNewChecklistGoal, targetNewChecklistGoal, bonusNewChecklistGoal);

                _goalsList.Add(newCheckListGoal);//adding the new goal

                break;
        }


    }

    public void RecordEvent()
    {
        //This method will ad points into the Score

        Console.WriteLine("\nWhat is the goal?");

        ListGoalNames();

        Console.WriteLine();

        ShowSpinner();

        int goalSelected = int.Parse(Console.ReadLine()) - 1;

        _goalsList[goalSelected].RecordEvent();
        
        _score += _goalsList[goalSelected].GetPoints();

    }

    public void SaveGoals()
    {
        //This method will save the goals into one textfile

        using (StreamWriter outputFile = new StreamWriter($"{_nameUser}-goals.txt"))
        {
            outputFile.WriteLine(_nameUser);
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goalsList)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }

        }

        ShowSpinner();

        Console.WriteLine("\nYour goals were saved".ToUpper());
    }


    public void SubmitFile()
    {
        Console.WriteLine("What is the name of your file?");
        string _fileName = Console.ReadLine();

        //This Attributes/variables we are goin to use to compile the new file

        SimpleGoal newSimpleGoal;
        EternalGoal newEternalGoal;
        ChecklistGoal newCheckListGoal;
        string nameGoal;
        string desGoal;
        string poinGoal;
        bool statusGoal;

        try
        {
            string[] lines = System.IO.File.ReadAllLines(_fileName);

            if (lines.Length > 0)
            {
                _nameUser = lines[0];
                _score = int.Parse(lines[1]);
                
                for (int i = 2; i < lines.Length; i++)
                {
                    string line = lines[i];

                    /*In this part we are validating what kind of goal we are getting*/
                    string[] parts = line.Split(":");
                    string typeOfGoal = parts[0];
                    string goalFromFile = parts[1];

                    string[] goalParts = goalFromFile.Split(",");//Here we are splitting the goals

                    switch (typeOfGoal)
                    {
                        case "SimpleGoal":
                            nameGoal = goalParts[0];
                            desGoal = goalParts[1];
                            poinGoal = goalParts[2];
                            if (goalParts[3] == "False") { statusGoal = false; } else { statusGoal = true; }

                            //Create the newGoal
                            newSimpleGoal = new SimpleGoal(nameGoal, desGoal, poinGoal, statusGoal);

                            _goalsList.Add(newSimpleGoal);

                            break;

                        case "EternalGoal":
                            nameGoal = goalParts[0];
                            desGoal = goalParts[1];
                            poinGoal = goalParts[2];

                            //Create the newGoal
                            newEternalGoal = new EternalGoal(nameGoal, desGoal, poinGoal);

                            _goalsList.Add(newEternalGoal);

                            break;

                        case "ChecklistGoal":
                            nameGoal = goalParts[0];
                            desGoal = goalParts[1];
                            poinGoal = goalParts[2];
                            int bonusGoal = int.Parse(goalParts[3]);
                            int tarGoal = int.Parse(goalParts[4]);
                            // int amGoal = int.Parse(goalParts[5]);

                            //Create the newGoal
                            newCheckListGoal = new ChecklistGoal(nameGoal, desGoal, poinGoal, tarGoal, bonusGoal);

                            _goalsList.Add(newCheckListGoal);
                            break;
                    }

                }
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"\n\nTHE FILE WAS NOT FOUND\n{ex}\n");
            Console.ReadLine();
            ShowSpinner();
            Console.Clear();
        }
    }
    public void LoadGoals()
    {
        int choice = 3;

        Console.WriteLine("Do you want to delete the current goals? or combine the new file?");
        Console.WriteLine("1.Delete\n2.Combine");

        while (choice > 2)//We are ensuring that the user will write a correct answer.

            choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    //This option will be delete the current goals and provide a new goal manager

                    _goalsList.Clear();
                    SubmitFile();
                    ShowSpinner();
                    Console.WriteLine("DONE!!");
                    Console.ReadLine();
                    Console.Clear();


                    break;//Here ends the case 1

                case 2:

                    //The same process but the difference is that we are not cleaning the list.
                    SubmitFile();
                    ShowSpinner();
                    Console.WriteLine("DONE!!");
                    Console.ReadLine();
                    Console.Clear();

                    break;//here ends the case2 
                case > 2:
                    Console.WriteLine("Invalid");
                    break;
                case < 1:
                    Console.WriteLine("Invalid");
                    break;
            }
    }
    // Spinner to charge to wait and make dynamic the program.
    void ShowSpinner()
    {

        List<string> signs = new List<string>() { "|", "\\", "—", "/" };

        //Local Method Variables for Timing
        DateTime startTiming = DateTime.Now;
        DateTime endTiming = startTiming.AddSeconds(5);

        Console.WriteLine("Get ready...");
        while (DateTime.Now < endTiming)
        {
            foreach (string i in signs)
            {
                Console.Write(i);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        };

    }
}