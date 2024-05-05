using System;

public class PromptGenerator {
    public List <string> _prompt;
    
    public string GetRandomPrompt(){
        List<string> _prompt = new List<string>();
        _prompt.Add("What was a new thing you learned today?");
        _prompt.Add("What was the best part of my day?");
        _prompt.Add("Who was the most interesting person I interacted with today?");
        _prompt.Add("What challenge did you manage to overcome today?");
        _prompt.Add("What change did you do today?");
        _prompt.Add("Did you live interesting something today to tell your grandchildren?");
        _prompt.Add("Did you establish a new goal in your life? which?");
        _prompt.Add("What dream you have achieved to fulfill today?");
        _prompt.Add("Did you have a good memory today?");
        Console.WriteLine(_prompt.Count);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,_prompt.Count);
        Console.WriteLine(_prompt[number]);
        

       


        return "";
    }
}