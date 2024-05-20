using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        f1.SetTop(1);
        f1.SetBottom(3);
        Console.WriteLine(f1.GetTop());
        Console.WriteLine(f1.GetBottom());
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        //Fraction f2 = new Fraction(6);
        //Fraction f3 = new Fraction(6,7);

        //Console.WriteLine(f1);
    }
}