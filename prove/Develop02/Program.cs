using System;

class Program
{
    static void Main(string[] args)
    {  
    
        Journal myJournal =  new Journal();
        Console.WriteLine("Welcome to the Journal Program");
        Start:
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        string option = Console.ReadLine();
        //int option = int.Parse(temp);
        switch (option){
            case "1":
                // Generate questions
                Entry text = new Entry();
                PromptGenerator temp = new PromptGenerator();
                string prompt_temp = temp.GetRandomPrompt();
                Console.WriteLine(prompt_temp);
                text._promptText = prompt_temp;
                text._entryText = Console.ReadLine();
                //Journal myJournal =  new Journal();
                myJournal.AddEntry(text);
                goto Start;
            case "2":
                myJournal.DisplayAll();
                goto Start;
            case "3":
                Console.WriteLine("What is the name of the file?");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
                goto Start;
            case "4":
                Console.WriteLine("What is the name of the file?");
                string namefile = Console.ReadLine();
                myJournal.SavetoFile(namefile);
                goto Start;
            case "5":

                break;
            }



        }
        //PromptGenerator temp = new PromptGenerator();
        //Console.WriteLine(temp.GetRandomPrompt());
        //string prompt_temp = temp.GetRandomPrompt();
        // ask and received text from user
        //Entry entry = new Entry();
        //entry._entryText = Console.ReadLine();
        
        // journal
        //Journal myJournal =  new Journal();
        //myJournal.AddEntry(entry);

    }