using System;

public class Scripture {

    //Attributes 

    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private string _quote;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _quote = text;
        
        string[] linesInText = text.Split(new string[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);

        foreach (string line in linesInText)
        {
            string[] wordsInLine = line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            foreach (string wordText in wordsInLine)
            {
                Word word = new Word(wordText);
                _words.Add(word);
            }
        }
        
    }

    // private void SplitIntoWords(string scriptureText){

    //     string[] line = scriptureText.Split("");



    // }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText() //delete the attribute.
    {
        string textDisplayed = $"{_reference.GetDisplayText()} : {_quote}";

        return textDisplayed;
    }


    public bool IsCompletelyHidden(bool a)//Delete the attribute
    {
        return a;
    }
}