using System;

public class Person{
    //public string _givenName = "";
    //public string _familyName = "";

    //public Person ()
    //{

    //}

    //public void ShowEasterName ()
    //{
        //Console.WriteLine($"{_familyName}, {_givenName}");
    //}

    //public void ShowWesternName()
    //{
        //Console.WriteLine($"{_givenName} {_familyName}");
    //}
    private string _title;
    private string _firstName;
    private string _lastName;
     
    public string GetInformalSignature(){
        return "Thanks," + _firstName;
    }

    public string GetFormalSignature(){
        return "Sincerely," + GetFullName();
    }

    private string GetFullName(){
        return _title + " " + _firstName + " " + " " + _lastName;
    }
    

    // GETTER AND SETTER
    public string GetFirstName()
    {
        return _firstName;
    }

    public void SetFirstName(string firstName){
        _firstName = firstName;
    }
}