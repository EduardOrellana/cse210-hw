public class Reference {
    //Reference class to keep the references

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        //Inserting the attributes into the variables.
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        //Inserting the attributes into the variables.
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()//delte attribute
    {
        string textDisplayed;
        
        if (_endVerse > 0)
        {
            textDisplayed = $"{_book} {_chapter}:{_verse} ";
        }
        else
        {
            textDisplayed = $"{_book} {_chapter}:{_verse} ";
        }

        return textDisplayed;
    }


}