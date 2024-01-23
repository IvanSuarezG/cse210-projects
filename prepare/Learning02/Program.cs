using System;public 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._company = "Alimentos Carnicos";
        job1._jobTitle = "Tecnico de mantenimiento";
        job1._startYear = 2019;
        job1._endYear = 2025;
        job1.Display();

        Job job2 = new Job();
        job2._company = "Sílex Automation";
        job2._jobTitle = "Diseñador";
        job2._startYear = 2021;
        job2._endYear = 2070;
        job2.Display();
    }
}