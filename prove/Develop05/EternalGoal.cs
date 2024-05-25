using System.Diagnostics;
using System.Globalization;

public class EternalGoal : Goal
{
    //Methods

    public EternalGoal(string name, string description, string points) : base (name, description, points)
    {}

    public override void RecordEvent()
    {
        Console.WriteLine($"\nCongratulations! You have earned {_points} points\n");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }




}