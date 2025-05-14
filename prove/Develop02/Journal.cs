using System;
using System.IO; 

public class Journal{
    public List <Entry> _entries = new List<Entry> ();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll(){
        foreach (var entry in _entries)
        {
            entry.Display();
        }

    }
    

    public void SavetoFile(string file){
        using (StreamWriter outputFile = new StreamWriter(file)){
            outputFile.WriteLine(_entries);
        }

    }

    public void LoadFromFile(string file){
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines){
            string[] parts = line.Split(",");
        }
        }
        

    }


