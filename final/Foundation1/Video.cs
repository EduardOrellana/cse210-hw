public class Video 
{
    private string _author;
    private string _title;
    private int _length;

    private List<Comment> _comments = new List<Comment>();


    //Constructor
    public Video(string author, string title, int length)
    {
        _author = author;
        _title = title;
        _length = length;
    }

    //Getters and Setters
    
    public string GetAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public int GetLength()
    {
        return _length;
    }

    public void SetLength(int length)
    {
        _length = length;
    }

    //Methods

    public void SetComments(string person, string comment)
    {   
        //This method will add into the list of the comment the comments of the video
        Comment com = new Comment(person, comment);
        
        _comments.Add(com);
    }

    public void PrintTotalComments()
    {
        int count = 0;
        foreach (Comment i in _comments)
        {
            count ++;
            Console.WriteLine($"\nComment {count}");
            Console.Write("Person: ");
            Console.WriteLine(i.GetPerson());
            Console.Write("Comment: ");
            Console.WriteLine(i.GetComment());
        }

        string message = $"\nThe total comments are: {_comments.Count}";

        Console.WriteLine(message);
    }



}