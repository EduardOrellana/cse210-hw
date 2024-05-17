public class Activity {
    //Base Class


    //Attributes we are going to use Procted type

    protected string _name;
    protected string _description;
    protected int _duration;


    public Activity(string name, string description){

        //Constructor

        _name = name;
        _description = description;

    }


    public void DisplayStartingMessage(){

        //Printing the welcome message we are going to use the variable _name with a set of strings

        Console.WriteLine($"Welcome to {_name}.\n");
        Console.WriteLine(_description);
        Console.Write($"How long, in seconds, would you like for your sesions? ");
        _duration = int.Parse(Console.ReadLine());

    }

    public void DisplayEndingMessage(){

        Console.Write($"You have completed another {_duration} seconds of the {_name}");

    }

    public void ShowSpinner(int seconds){

        List<string> signs = new List<string>(){"|", "\\", "—", "/"};
        
        //Local Method Variables for Timing
        DateTime startTiming = DateTime.Now;
        DateTime endTiming = startTiming.AddSeconds(seconds);
        
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

    public void ShowCountDown(int seconds){
        //Will be a timer by 5 seconds.

        Console.Write("You may begin in: ");

        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        };


    }
}