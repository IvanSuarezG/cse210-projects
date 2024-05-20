using System;

class Program
{
    static void Main(string[] args)
    {
        
        string scripture = "I will go and do";
        Reference Scripture_reference = new Reference("Proverbios", 3, 5, 6);
        Scripture text_scripture = new Scripture(Scripture_reference, scripture);
        text:
        Console.WriteLine(text_scripture.GetDisplayText());
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 10); 
        text_scripture.HideRandomWords(number);
        
       while(true)
       {
        string input = Console.ReadLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        if (string.IsNullOrEmpty(input))
        {
             goto text;
        }
        else if (input == "quit")
        {
            Console.Clear();
            break;
        }
       }
    }
}