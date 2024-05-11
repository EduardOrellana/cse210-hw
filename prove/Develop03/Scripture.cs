public class Scripture {

    //Attributes 

    private Reference _reference;
    private List<Word> _words = new List<Word>();
    
    // private string _quote; I'll try to work only with the attributes that the instructions are telling me.

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        
        string[] linesInText = text.Split(new string[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries); //We are ensuring the paragrahp.

        foreach (string line in linesInText)
        {
            string[] wordsInLine = line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries); //here we are extracting the line.

            foreach (string wordText in wordsInLine)
            {
                Word word = new Word(wordText);
                _words.Add(word);
            }
        }  
    }

    public void HideRandomWords(int numberToHide)
    {
        //This method will hide some of randomWords.

        Random _randomWord = new Random(); //to get a random word.

        int _randomWordIndex;
        int _totalWords = _words.Count;

        for (int i = 1; i <= numberToHide; i++)
        {
            _randomWordIndex = _randomWord.Next(0, _totalWords);
            
            if (_words[_randomWordIndex].isHidden() != true)
            {
                _words[_randomWordIndex].Hide(); //I can use the methods no matter if the class is an list, regarding the index of the random the index will localize some word and then with the method of hide from the class word, we are going to hide the word.
            }
            else
            {
                foreach (Word word in _words) //here I'm ensuring that the code will hide another word.
                {
                    if (word.isHidden() != true)
                    {
                        word.Hide();
                        break;
                    }
                }
            }
            
        }

    }

    public string GetDisplayText()
    {
        
        string textDisplayed = $"{_reference.GetDisplayText()}";

        foreach (Word word in _words)
        {
            textDisplayed += word.GetDisplayText() + " ";
        }

        return textDisplayed.Trim();
    }


    public bool IsCompletelyHidden()
    {
        //Will start reset the words
        bool _completeHidden = false;
        int _count = 0;
        int _totalWords = _words.Count;

        foreach (Word word in _words)
        {
            if (word.isHidden())
            {
                _count += 1;
            }
        }

        if (_count == _totalWords)
        {
            _completeHidden = true;
        }
        
        return _completeHidden;
    }
}