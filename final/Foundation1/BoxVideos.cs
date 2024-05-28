public class BoxVideos
{


    private List<Video> _videos = new List<Video>()
    {
        new Video("Erick", "How to create a Dashboard in Power BI", 2000),

        new Video("Eduardo", "Top 5 tools to learn on Internet", 1000),

        new Video("Roger", "Top 10 the best videogames of 2024", 500),

        new Video("Cliff", "Top 10 worst languge programming to learn code", 600)
    };


    public void SettingPrincipalComments()
    {
        //Comments of the first video:
        _videos[0].SetComments("Stuar", "Greate Video");
        _videos[0].SetComments("Maria", "Thanks a lot, I could learn a lot");
        _videos[0].SetComments("Roxy", "What is DAX Language?");

        //Comments of the second video
        _videos[1].SetComments("Stuar", "I got my all knowledge of Python on Internet");
        _videos[1].SetComments("Luigi", "Internet has been declare a new era in educaction");
        _videos[1].SetComments("Richard", "I liked your video.");

        //Comments of the third video
        _videos[2].SetComments("Jeff", "I'm playing the first videogame each night's friday");
        _videos[2].SetComments("Charlie", "Why Call Of Duty is the number 7? it must be the first videogame! is the best videogame of the world!");
        _videos[2].SetComments("Katherine", "The videogames are not good for our children we must be carefully with the internet and the videogames.");

        //Comments of the forth video.
        _videos[3].SetComments("Carol", "I passed the same problem learning Java, but when you leanr Java Everything is going to be easy peasy lemon quizy");
        _videos[3].SetComments("Bryan", "The most important Language to me is Python, for Data Analyst Python will be number one");
        _videos[3].SetComments("Lety", "I was going to give you a like, but you mentioned something that I'm not agree with it");

    }


    public void AddNewVideo(string author, string title, int lenght)
    {
        //Adding a new video into our principal list.

        Video newVideo = new Video(author, title, lenght);
        _videos.Add(newVideo);

    }

    public void DisplayVideos()
    {
        //This method will print the all videos and their total comments and their comments

        int count = 0;
        foreach (Video i in _videos)
        {
            //This for will run the list of the videos and their comments
            count ++;
            string author = i.GetAuthor();
            string title = i.GetTitle();
            int time = i.GetLength();

            Console.WriteLine($"\nVideo {count}: ");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Duration: {time}");

            Console.WriteLine("\nComments:");
            i.PrintTotalComments();

            ShowSpinner();
            Console.WriteLine();
        }
    }

    public void DisplayNamesOfVideos()
    {
        int count = 0;
        foreach (Video i in _videos)
        {
            //This for will run the list of the videos and their comments
            count ++;
            string author = i.GetAuthor();

            Console.WriteLine($"\nVideo {count}: ");
            Console.WriteLine($"Author: {author}");
        }
    }
    
    public void ShowSpinner()
    {

        List<string> signs = new List<string>() { "|", "\\", "—", "/" };

        //Local Method Variables for Timing
        DateTime startTiming = DateTime.Now;
        DateTime endTiming = startTiming.AddSeconds(3);

        Console.WriteLine("Loading...");
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

    public void SetTheComment(int videoSelected, string person, string comment)
    {
        //This method is allow to use the method of the video, we can use more principlaes such ass a Inheritance

        _videos[videoSelected].SetComments(person, comment);
    }

}