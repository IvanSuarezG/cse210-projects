using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string name = PromptUserName();
        int number = PromptUserNumber();
        int couple = SquareNumber(number);
        DisplayResult(couple, name);
        
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(){
        Console.Write("What is your name?  ");
        string _name = Console.ReadLine();

        return _name;
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        string num = Console.ReadLine();
        int number = int.Parse(num);
        return number;
    }

    static int SquareNumber(int value){
           int square = value * value;
           return square;
    }

    static void DisplayResult(int amount, string date){
        DisplayWelcome();
        Console.WriteLine($"{date}, The square of your number is {amount}");
    
    }
}