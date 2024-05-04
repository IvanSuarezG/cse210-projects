using System;

class Program
{
    static void Main(string[] args)
    {
       Resume person = new Resume();
       person._name = "Ivan Suarez";
       
       Job job1 = new Job ();
       job1._jobTitle = "Maintenance Technician";
       job1._company = "Alimentos Carnicos";
       job1._startYear = 2020;
       job1._endYear = 2024;

       Job job2 = new Job();
       job2._jobTitle = "Engineering area assitence";
       job2._company = "Servilonjas";
       job2._startYear = 2019;
       job2._endYear = 2020;

       person._jobs.Add(job1);
       person._jobs.Add(job2);

       person.display();

    }
}