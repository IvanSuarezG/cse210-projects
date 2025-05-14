using System;

public class Entry{
    public string _promptText;
    public string _entryText;
    DateTime _date = DateTime.Now;
    

    public void Display(){
        Console.WriteLine($"{_date}  Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        
    }
}
