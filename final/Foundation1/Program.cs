using System;

class Program
{
    static void Main(string[] args)
    {
        bool turnOn = true;
        BoxVideos play = new BoxVideos();
        play.SettingPrincipalComments();


        while (turnOn)
        {
            Console.Clear();
            Console.WriteLine("Welcome!!");

            Console.WriteLine("\nChoose one option: \n");
            Console.WriteLine("1. See all Videos");
            Console.WriteLine("2. Add a new Video");
            Console.WriteLine("3. Comment one video");
            Console.WriteLine("4. Exit");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    //Displaying the all videos
                    play.ShowSpinner();
                    Console.Clear();
                    play.DisplayVideos();
                    Console.ReadLine();
                    break;

                case 2:
                    play.ShowSpinner();
                    Console.Clear();

                    Console.Write("\nWho is the author of the video? ");
                    string nameAuthor = Console.ReadLine();

                    Console.Write("\nWhat is the name of the video? ");
                    string nameVideo = Console.ReadLine();
                    
                    Console.WriteLine("\nWhat is the duration in seconds of the video");
                    int durationVideo = int.Parse(Console.ReadLine());

                    play.AddNewVideo(nameAuthor, nameVideo, durationVideo);

                    Console.WriteLine("\nWe are submiting your video...");
                    play.ShowSpinner();
                    Console.WriteLine("\n\nWe've Finished");
                    Console.ReadLine();

                    break;

                case 3:

                    play.ShowSpinner();
                    Console.WriteLine("Which video do you want to comment?");
                    play.DisplayNamesOfVideos();
                    Console.WriteLine();
                    int videoToComment = int.Parse(Console.ReadLine()) - 1;


                    Console.WriteLine("\nWho is writing?");
                    string person = Console.ReadLine();
                    Console.Write("\n\nComment:");
                    string coment = Console.ReadLine();

                    play.SetTheComment(videoToComment, person, coment);

                    break;

                case 4:
                    turnOn = !turnOn;
                    break;
            }
        }

    }
}