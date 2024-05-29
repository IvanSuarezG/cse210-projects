using System;

public class WritingAssigment: Assigment{

    private string _title;


    public void SetTitle (string title){
        _title = title;
    }

    public string GetTitle(){
        return _title;
    }

    public string GetWritingInformation(){
        return $"{_title} by {GetStudentName()}";
        
    }
}