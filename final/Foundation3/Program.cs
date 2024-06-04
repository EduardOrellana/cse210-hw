using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //General Program Project Number 4

        Lecture event1 = new Lecture("The King Lion", "This event will have the purpose to read the work of the king Lion", "6/04/2024", new TimeOnly(13, 0, 0), new Address("1 Calle", "San Miguel Petapa", "Guatemala", "Guatemala"), "lecture", "Eduardo", 35);

        Receptions event2 = new Receptions("ore.@byu.com", "Smith's Weading", "Weading of Michael and July", "08/08/2024", new TimeOnly(15, 30, 0), new Address("Boulevard Jake", "Lehi", "Utah", "United States"), "reception", true);

        Outdoor event3 = new Outdoor("Summer tournament", "Each familiy is invited to participate with the community in our 5th tournament of summer", "07/05/2024", new TimeOnly(8, 0, 0), new Address("1 Avenue", "Quetzaltenango", "Quetzaltenango", "Guatemala"), "outdoor", "Cloudy");

        Console.WriteLine("\n------------------------First Event-------------------------------------\n");

        Console.WriteLine("-----------------Standar Details--------------------------------");
        Console.WriteLine(event1.StandarDetails());
        Console.WriteLine('\n');
        Console.WriteLine("-----------------Short Description--------------------------------");
        Console.WriteLine(event1.ShortDescription());
        Console.WriteLine('\n');
        Console.WriteLine("-----------------Full Details--------------------------------");
        Console.WriteLine(event1.FullDetails(event1.GetMessage()));

        //Event 2================================================================
        Console.WriteLine("\n------------------------ Second Event-------------------------------------\n");
        Console.WriteLine("-----------------Standar Details--------------------------------");
        Console.WriteLine(event2.StandarDetails());
        Console.WriteLine('\n');
        Console.WriteLine("-----------------Short Description--------------------------------");
        Console.WriteLine(event2.ShortDescription());
        Console.WriteLine('\n');
        Console.WriteLine("-----------------Full Description--------------------------------");
        Console.WriteLine(event2.FullDetails(event2.GetMessage()));


        Console.WriteLine("\n------------------------Third Event-------------------------------------\n");
        Console.WriteLine("-----------------Standar Details--------------------------------");
        Console.WriteLine(event3.StandarDetails());
        Console.WriteLine("\n-----------------Short Description--------------------------------\n");
        Console.WriteLine(event3.ShortDescription());
        Console.WriteLine('\n');
        Console.WriteLine("-----------------Full Description--------------------------------");

        Console.WriteLine(event3.FullDetails(event3.GetMessage()));

    }
}