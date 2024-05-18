public class BreathingActivity : Activity {

    public BreathingActivity(string name, string description) : base(name, description){

        _name = name;
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }

    public void Run(){

        DisplayStartingMessage();

        ShowSpinner(5);

        Console.Clear();

        //Local Method Variables for Timing
        DateTime startTiming = DateTime.Now;
        DateTime endTiming = startTiming.AddSeconds(_duration);

        while (DateTime.Now < endTiming)
        {
            Console.Write("Breathe in...");
            for (int i = 8; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            };

            Console.WriteLine();
            Console.Write("Now breathe out...");

            for (int i = 8; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            };

            //more quickly
            Console.WriteLine();
            Console.Write("Breathe in a little bit faster...");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            };

            Console.WriteLine();
            Console.Write("Now breathe out a little bit faster...");

            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            };

            Console.WriteLine();
            Console.WriteLine();

        }

        DisplayEndingMessage();
        Console.ReadLine();
        Console.Clear();
    }


}