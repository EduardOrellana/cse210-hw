using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        List<Activity> _activities = new List<Activity>()
        {

            new Running("Number two", "03 Jun 2024", 30, 3.5),
            new StationaryBicycles("Number 4", "10 May 2024", 50, 2),
            new Swimming("15 April 2024", 20, 15)
        };

        foreach (Activity i in _activities)
        {
            Console.WriteLine(i.GetSummary());
        }
    }
}