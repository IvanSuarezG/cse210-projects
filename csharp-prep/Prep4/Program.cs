using System;

using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num = 1;
        int sum = 0;
        double average = 9;
        int bigger = 0;


        while (num != 0){
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            string num_entered = Console.ReadLine();
            num = int.Parse(num_entered);

            if (num != 0)
            {
                numbers.Add(num);
            }  
        }
        foreach (int number in numbers){
            sum+= number;
            
        }
        Console.WriteLine($"The sum is: {sum}");
        int amount = numbers.Count;

        average = sum / amount;
        Console.WriteLine($"The average is: {average}");

        foreach (int number in numbers){
            if(number > bigger){
                    bigger = number;
                }
        }
        Console.WriteLine($"The largest number is: {bigger}");
        
        

    }
}


    
