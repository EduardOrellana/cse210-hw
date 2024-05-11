using System.Collections.Generic;
using System.Data;

public class ScriptureBox 
{
    //This class will contain random scritpures.


    private List<Scripture> _newScripturesAdded = new List<Scripture>();
    private List<Scripture> _scriptures = new List<Scripture>()
    {
        new Scripture(new Reference("John", 3,16), @"For God so loved the world"),

        new Scripture(new Reference("3 Nephi", 5, 13), @"Behold, I am a disciple of JesusChrist, the Son of God. I have been called of him to declare his word among his people, that they might have everlasting life."),

        new Scripture(new Reference("Moroni", 10,3,5), @"Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts.

        And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.

        And by the power of the Holy Ghost ye may aknow the truth of all things."),

        new Scripture(new Reference("Joshua", 1, 9), @"Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the Lord thy God is with thee whithersoever thou goest."),

        new Scripture(new Reference("Doctrine and Covenants", 1, 38), @"What I the Lord have spoken, I have spoken, and I excuse not myself; and though the heavens and the earth pass away, my word shall not pass away, but shall all be fulfilled, whether by mine own voice or by the voice of my eservants, it is the same.")
    };


    public Scripture randomScripture()
    {
        //This Function will be return a random Scripture.
        
        Random _randomScripture = new Random();

        int _randomIndex = _randomScripture.Next(1, _scriptures.Count);

        Scripture _scriptureReturn = _scriptures[_randomIndex];

        return _scriptureReturn;
    }

    public Scripture scriptureSelected(int index)
    {

        Scripture _scriptureReturn = _scriptures[index];

        return _scriptureReturn;
    }

    public void AddScripture(Scripture newScripture)
    {
        _scriptures.Add(newScripture);
        _newScripturesAdded.Add(newScripture);
    
    }

    public void printScriptures()
    {
        //This function will print the all Scriptures:
        int count = 1;
        foreach(Scripture item in _scriptures) //I've learned that KeyValuePair we can pass with the all dictionary
        {
            
            Console.WriteLine($"Scripture {count}\n");
            Console.WriteLine(item.GetDisplayText());
            Console.WriteLine();
            count++;
        }
    
        Console.WriteLine("New Scriptures Added:\n");
        foreach(Scripture item in _newScripturesAdded) //I've learned that KeyValuePair we can pass with the all dictionary
        {
            Console.WriteLine(item.GetDisplayText());
            Console.WriteLine();
        }
    }
}