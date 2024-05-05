using System;

public class Journal{
    public List <Entry> _entries = new List<Entry> ();
    public void AddEntry(Entry newEntry)
    {
            
            

    }

    public void DisplayAll(){
        foreach (Entry entry in _entries)
        {
              entry.Display();
        }

    }

    public void SavetoFile(string file){

    }

    public void LoadFromFile(string file){

    }

}
