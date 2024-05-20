using System;




public class Scripture{

    private Reference _reference;
    private List<Word> _words;
    
    public Scripture(Reference _infoText, string Text){
        _reference = _infoText;
        _words = new List<Word>();
        string[] words = Text.Split(" ");
  
        foreach (string word in words){
            Word w = new Word(word);
            _words.Add(w);
        }  
    }
  

    public void HideRandomWords(int NumberToHide ){
        int Num = NumberToHide;
        int amount = _words.Count;
        Console.WriteLine($"the amount is: {amount}");

        for (int i=0; i<amount; i = Num-1)
        {

               Console.WriteLine($"{_words[i]}");
        }

    }
    public string GetDisplayText(){
        
        return _reference.GetDisplayText() + " : " + GetWordsText();

    }

    public bool IsCompletelyHidden(){
        return false;
    }
    
    public string GetWordsText()
    {
        List<string> wordsText = new List<string>();

        foreach (Word word in _words)
        {
            wordsText.Add(word.GetDisplayText());
        }

        return string.Join(" ", wordsText);
    }

}