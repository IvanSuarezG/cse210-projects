using System;

public class MathAssigment : Assigment {

    private string _textbookSection;
    private string _problems;


    public void SetTextbookSection(string textbookSection){
        _textbookSection = textbookSection;
    }

    public void SetProblems(string problems){
        _problems = problems;
    }

    public string GetTextbookSection(){
        return _textbookSection;
    }

    public string GetProblems(){
        return _problems;
    }

    public string GetHomeworkList(){
        return $"{_textbookSection}  : {_problems}";
    }


}