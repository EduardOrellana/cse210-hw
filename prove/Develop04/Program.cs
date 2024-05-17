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

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        //Starting of the activity.

        //variables
        int menuSelected = 0;
        int numberValidator; //We are going to use this variable to ensure our input from de user.


        do
        {

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Exit");

            while (true)
            {
                string inputUser = Console.ReadLine();
                bool validator = int.TryParse(inputUser, out numberValidator);
                

                if (inputUser == "" || (!validator))
                {
                    Console.WriteLine("\n this option is invalid\n");
                }
                else if (validator)
                {
                    menuSelected = int.Parse(inputUser);
                    if (menuSelected > 4 || menuSelected <= 0)
                    {
                        Console.WriteLine("Wrong Option");
                    }
                    break;
                }
            }
            
            switch (menuSelected)
            {
                case 1:
                    BreathingActivity breathingActivity1 = new BreathingActivity("Breathing Activity", "");

                    breathingActivity1.Run();
                    
                    break;
                
                case 2:

                    ReflectionActivity reflectionActivity1 = new ReflectionActivity("Reflection Activity", "");

                    reflectionActivity1.Run();

                    break;
                
                case 3:

                    ListiningActivity listiningActivity1 = new ListiningActivity("Listing Activity", "");

                    listiningActivity1.Run();

                    break;
            }




        }while (menuSelected !=4);

    }
}