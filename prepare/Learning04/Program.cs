using System;

class Program
{
    static void Main(string[] args)
    {
        //Assigment student_1 = new Assigment();
        //student_1.SetStudentName("Ivan Suarez");
        //student_1.SetTopic("Programming with classes");
        //Console.WriteLine(student_1.GetSummary());

        //MathAssigment student_2 = new MathAssigment();
        //student_2.SetStudentName("Ivan Suarez");
        //student_2.SetTopic("Inheritance");
        //student_2.SetTextbookSection("Section 7.3");
        //student_2.SetProblems("Problems 8-9");
        //Console.WriteLine(student_2.GetHomeworkList());

        WritingAssigment student_3 = new WritingAssigment();
        student_3.SetStudentName("Ivan Suarez");
        student_3.SetTopic("European History");
        student_3.SetTitle("The causes of World War II");
        Console.WriteLine(student_3.GetSummary());
        Console.WriteLine(student_3.GetWritingInformation());


    }
}