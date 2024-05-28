public class Comment
{
    //Attributes
    private string _person;

    private string _comment;

    public Comment(string person, string com) //Constructor.
    {
        _person = person;
        _comment = com;
    }

    //Getters and setters;

    public string GetPerson()
    {
        return _person;
    }

    public void SetPerson(string person)
    {
        _person = person;
    }

    public string GetComment()
    {
        return _comment;
    }

    public void SetComment(string com)
    {
        _comment = com;
    }



}