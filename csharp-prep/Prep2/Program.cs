using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Start:
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        string temp = Console.ReadLine();
        int option = int.Parse(temp);
        
            switch(option)
            {
                case 1:
                    PromptGenerator new_prompt = new PromptGenerator();
                    new_prompt.GetRandomPrompt();
                    Entry entry = new Entry();
                    entry._entryText =Console.ReadLine();
                    Journal new_entry = new Journal();
                    new_entry.AddEntry(entry);   
                    goto Start;              
                case 2: 
                    Journal entries = new Journal();
                    entries.DisplayAll();
                    goto Start;
                case 3:
                    Console.WriteLine("Niether");
                    goto Start;
                case 4: 
                    Console.WriteLine("anything");
                    goto Start;
                case 5:
                    Console.WriteLine("End");
                    goto Start;
            } 
    }
}
