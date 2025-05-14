using System;

public class PromptGenerator {
    public List<string> _prompt = new List<string> {

        "What was a new thing you learned today?",
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today?",
        "What challenge did you manage to overcome today?",
        "What change did you do today?",
        "What was the most fun thing you did today?",
        "What was the most beautiful thing you saw today?",
        "Did you establish a new goal in your life? which?",
        "What dream you have achieved to fulfill today?",
        "What was the most difficult thing you did today?",
        "What was the most interesting thing you learned today?",
        "What was the most important thing you did today?",
        "Did you have a good time with your friends today?",
        "Did you have a good time with your family today?",
        "Did you have a good time with your pets today?",
        "Did you have a good memory today?"
    };
    
    public string GetRandomPrompt()
    {
        // Randomly select a prompt from the list
        // and return it
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _prompt.Count);
        string index= _prompt[number];
        return index;
    }
}
        

