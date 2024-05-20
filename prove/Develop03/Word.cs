using System;


public class Word{
    private string _text;
    private bool _isHidden;

    public Word(string Text){
        _text = Text;
        _isHidden = false;

    }
    
    
    public void Hide(){
         _isHidden = true;
    }

    public void Show(){

    }

    public bool IsHidden(){
        return false;
    }

    public string GetDisplayText(){
        return _text;
    }
}