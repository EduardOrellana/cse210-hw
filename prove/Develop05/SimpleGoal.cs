public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, string points) : base(name, description, points){} //By the base constructor we are going to obtain the
    //names, descriptions and points.

    public override void RecordEvent()
    {
        _isComplete = true;
    }


    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal: {_shortName},{_description},{_points}";
    }




}