using System.Collections.Generic;

public class PromptGenerator {

    public List<string> _prompts = new List<string>()
    {
        "What is the most important thing you have done today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What do you prefer to change about this day?",
        "What did you eat today?",
        "What did you learned today?",
        "What is something interisting about you?",
        "Where did you take you lunch?",
        "What do you want to do tomorrow?",
        "What was your last movie that you watched in the cinema?",
        "Do you have pets? if you have please write about your pets",
        "What is your profession?",
        "What is your favorite sport?"
    };
    Random _randomPrompt = new Random();

    public string GetRandomPrompt()
    {
        int _randomIndex = _randomPrompt.Next(0, _prompts.Count);

        string _randomPromptString = _prompts[_randomIndex];

        return _randomPromptString;
    }


}