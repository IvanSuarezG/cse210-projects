using System;


class Program
{
    static void Main(string[] args)
    {
     //Person person = new Person ();
     //person._givenName = "Ivan";
     //person._familyName = "Suarez";
     //person.ShowEasterName();
     //person.ShowWesternName();

     //Blind kitchen = new Blind();
     //kitchen._width = 60;
     //kitchen._height = 48;
     //kitchen._color = "White";

     //double materialAmount = kitchen.GetArea();
     //Console.WriteLine($"The area of blind in kitchen is {materialAmount} cm2");

     //Blind livingRoom = new Blind();
     //livingRoom._width = 72;
     //livingRoom._height = 52;
     //livingRoom._color = "Blue";

     //double materialAmount_living = livingRoom.GetArea();
     //Console.WriteLine($"The area of blind in living is {materialAmount_living} cm2");
     
     //House ivanHome = new House();
     //ivanHome._kitchen = new Blind();
     //ivanHome._livingRoom = new Blind();
     //ivanHome._owner = "Suarez Bermudez";
     //ivanHome._kitchen._width = 60;
     //ivanHome._kitchen._height = 48;
     //ivanHome._kitchen._color = "White";
     //double materialAmount = ivanHome._kitchen.GetArea();
     //Console.WriteLine($"The area of blind in kitchen is {materialAmount} cm2 in the home of {ivanHome._owner}");
       
       //Person person_1 = new Person();
       //person_1.SetFirstName("Ivan");
       //Console.WriteLine(person_1.GetFirstName());
       
       Resume name = new Resume();
       name._name = "Ivan Suarez";
       name.display();
       Job job_1 = new Job ();
       job_1._company = "Alimentos Carnicos";
       job_1._jobTitle = "Maintenance Technician";
       job_1._startYear = 2020;
       job_1._endYear = 2024;
       job_1.JobInformation();

       Job job_2 = new Job();
       job_2._company = "Pharmaceutical Fenix";
       job_2._jobTitle = "Assitant Maintenance Technician";
       job_2._startYear = 2019;
       job_2._endYear = 2020;
       job_2.JobInformation();





    }
}