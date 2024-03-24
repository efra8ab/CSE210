using System;
using System.Runtime.CompilerServices;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {
        
    }

    public void AddEntry(Entry newEntry)
    { _entries.Add(newEntry);}

    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            Console.WriteLine(entry.DisplayText());
        }
    }

    public void SaveFile()
    {
        Console.WriteLine("Enter the file name to save your entries");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in _entries)
            {
                string entryText = $"{entry._date}-{entry._promptText}-{entry._entryText}";
                outputFile.WriteLine(entryText);
            }

        }
        Console.WriteLine("Entries saved!");
    }

    public void LoadFile()
    {
        Console.WriteLine("Enter the file name to load your entries from: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _entries.Clear();

        foreach(string line in lines)
        {
            string[] parts = line.Split("-");

            if(parts.Length == 3)
            {
                Entry entry = new Entry();
                entry._date = parts[0].Trim();
                entry._promptText = parts[1].Trim();
                entry._entryText = parts[2].Trim();

                _entries.Add(entry);
            }
        }

        DisplayAll();
    }

}