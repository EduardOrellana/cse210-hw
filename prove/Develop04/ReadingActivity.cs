public class ReadingActivity : Activity {

    private List<string> _phrases = new List<string>()
    {
        "All our dreams can come true, if we have the courage to pursue them.\n — Walt Disney",
        "The future belongs to those who believe in the beatuy of their dreams.\n — Eleanor Roosevelt",
        "Dreams come true. Withour that possibility, nature would not incite us to have them.\n — John Updike",
        "Dream as if you'll live forever. Live as if you'll die today.\n — James Dean",
        "Strength does not come from winning. Your struggles develop your strengths.\n When you go through hardships and decide not to surrender, that is strength. — Arnold Schwarzenegger",
        "When you get into a tight place and everything goes against you, till it seems as though you could not hang on a minute longer, never give up then, for that is just the place and time that the tide will turn.\n — Harriet Beecher Stowe",
        "The best way out is always through.\n — Robert Frost",
        "It is not the critic who counts; not the man who points out how the strong man stumbles, or where the doer of deeds could have done better.\n The credit belongs to the man who is actually in the arena, whose face is marred by dust and sweat and blood...\n who at the worst, if he fails, at least fails while daring greatly, so that his place shall never be with those cold and timid souls who \nneither know victory nor defeat.\n — Theodore Roosevelt",
        "The greater the obstacle, the more glory in overcoming it.\n — Molière",
        "In a moment of decision, the best thing you can do is the right thing to do,\n the next best thing is the wrong thing, and the worst thing you can do is nothing.\n — Theodore Roosevelt",
        "Amateurs sit and wait for inspiration, the rest of us just get up and go to work.\n — Stephen King",
        "You will never plough a field if you only turn it over in your mind.\n — Irish proverb",
        "Take the first step in faith. You don't have to see the whole staircase,\n just take the first step.\n — Martin Luther King, Jr.",
        "Don't wait. The time will never be just right.\n — Napoleon Hill"
    };

    public ReadingActivity(string name, string description) : base(name, description){//constructor

        _name = name;
        _description = "This Activity will display you several motivational Phrases to take a little break";

    }

    public void Run(){
        Console.Clear();

        DisplayStartingMessage();

        Console.Clear();

        ShowSpinner(5);

        Console.WriteLine("Read the follor phrases: ");

        DateTime startTiming = DateTime.Now;
        DateTime endTiming = startTiming.AddSeconds(_duration);

        while (DateTime.Now < endTiming)
        {
            DisplayPhrase();;

        }
        
        Console.WriteLine("\nWell done!");

        DisplayEndingMessage();
        Console.ReadLine();
        Console.Clear();

    }


    public string GetRandomPhrase(){

        Random _randomPhraseNumber = new Random();

        int _randomPhraseIndex = _randomPhraseNumber.Next(0, _phrases.Count);

        string _randomPhrase = _phrases[_randomPhraseIndex];

        return _randomPhrase;


    }


    public void DisplayPhrase(){


        string phrase = GetRandomPhrase();

        string[] lines = phrase.Split("\n");

        Console.WriteLine();

        foreach (string line in lines)
        {
            Console.WriteLine(line);
            Thread.Sleep(4000);
            Console.WriteLine();
        }

    }

}

