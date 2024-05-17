public class ReflectionActivity : Activity {

    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless"
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string name, string description)  : base(name, description){

        //specif description =

        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _name = name;
        _description = description;

    }

    public void Run(){

        Console.Clear(); //Cleaning the Terminal
        
        //Presentation:

        DisplayStartingMessage();

        Console.Clear();

        ShowSpinner(5); //spinner

        Console.WriteLine("Consider the following prompt:\n");
        DisplayPrompt(); // Displaying a Prompt

        Console.WriteLine("\nWhen you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        ShowCountDown(5);

        //Local Method Variables for Timing
        DateTime startTiming = DateTime.Now;
        DateTime endTiming = startTiming.AddSeconds(_duration);
        
        while (DateTime.Now < endTiming)
        {
            DisplayQuestion();
            ShowSpinner(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();
        Console.ReadLine();
        Console.Clear();
    
    }

    public string GetRandomPrompt(){

        Random _randomPrompt = new Random();//to obtain a random number

        int _randomINdex = _randomPrompt.Next(0, _prompts.Count);

        string _randomPromptString = _prompts[_randomINdex];

        return(_randomPromptString);
    }

    public string GetRandomQuestion(){
        
        Random _randomQuestion = new Random();

        int _randomQuestionIndex = _randomQuestion.Next(0, _questions.Count);

        string _randomQuestionString = _questions[_randomQuestionIndex];

        return(_randomQuestionString);
    }

    public void DisplayPrompt(){
        //This measure will display the Random Prompt.

        string prompt = GetRandomPrompt();

        Console.WriteLine($" --- {prompt} ---");

    }

    public void DisplayQuestion(){
        //This measure will display/print the question.

        string question = GetRandomQuestion();

        Console.Write($"\n{question}");
        
    }


}