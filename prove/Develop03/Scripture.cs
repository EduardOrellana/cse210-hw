public class Scripture {

    //Attributes 

    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        
        




        
    }

    // private void SplitIntoWords(string scriptureText){

    //     string[] line = scriptureText.Split("");



    // }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText(string a) //delete the attribute.
    {
        return a;
    }


    public bool IsCompletelyHidden(bool a)//Delete the attribute
    {
        return a;
    }
}