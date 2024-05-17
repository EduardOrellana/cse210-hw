public class ListiningActivity : Activity{

    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListiningActivity(string name, string description) : base(name, description){

        _name = name;
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }


    public void Run(){

        Console.Clear();

        //presentation
        DisplayStartingMessage();

        Console.Clear();

        ShowSpinner(5);

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        ShowCountDown(5);
        Console.WriteLine();

        List<string> listUser = GetListFromUser();

        DisplayEndingMessage();
        Console.ReadLine();
        Console.Clear();



    }

    public void GetRandomPrompt(){

        Random _randomPrompt = new Random();//to obtain a random number

        int _randomINdex = _randomPrompt.Next(0, _prompts.Count);

        string _randomPromptString = _prompts[_randomINdex];

        Console.WriteLine($" ---{_randomPromptString}--- ");

    }

    public List<string> GetListFromUser(){

        //Local Method Variables for Timing
        DateTime startTiming = DateTime.Now;
        DateTime endTiming = startTiming.AddSeconds(_duration);
        List<string> listFromUser = new List<string>();

        while (DateTime.Now < endTiming)
        {
            listFromUser.Add(Console.ReadLine());

        }
        
        Console.WriteLine($"\nYou listed {listFromUser.Count} items!");
        Console.WriteLine("\nWell done!");


        return listFromUser;
    }

}