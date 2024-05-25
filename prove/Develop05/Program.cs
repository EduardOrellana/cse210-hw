using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalManager goalM;
        Console.WriteLine("Welcome to this wonderful Program\nWhat is your Name?");
        string name = Console.ReadLine();
        Console.WriteLine();
        // ShowSpinner();
        
        bool exit = true;
        goalM = new GoalManager(name); //Creating the goal Manager

        while (exit)
        {
            goalM.Start();

            string actionFromUser = Console.ReadLine();

            switch (actionFromUser)
            {
                case "1":
                    goalM.CreateGoal();
                    Console.WriteLine();
                    // ShowSpinner();
                    break;

                case "2":
                    goalM.ListGoalDetails();
                    Console.WriteLine();
                    goalM.DisplayPlayerInfo();
                    break;

                case "3":
                    goalM.SaveGoals();
                    break;

                case "4":
                    goalM.LoadGoals();
                    break;

                case "5":
                    goalM.RecordEvent();
                    break;

                case "6":
                    exit = false;
                    break;
            }

        }

        
    }
}