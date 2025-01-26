using System.IO;
using System.Xml;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {

    }

    public void AddEntry(PromptGenerator randomPrompt)
    {
        string prompt = randomPrompt.RandomPrompt();
        Console.WriteLine($"{prompt}:");
        Console.Write(">> ");
        string newEntry = Console.ReadLine();

        var entry = new Entry();
        entry._prompt= prompt;
        entry._entry = newEntry;

        _entries.Add(entry);
        Console.WriteLine("New entry saved...");
    }

    public void ViewEntries()
    {
        foreach (var entry in _entries)
        {
            Console.Write("-> ");
            entry.Display();
            Console.WriteLine("");
        }
        Console.WriteLine("Press enter to continue...");
    }

    public void SaveEntries()
    {
        Console.Clear();
        Console.WriteLine("Write down the name for your document (.txt or .csv file)");
        string fileName = Console.ReadLine();

        using (var newFile = new StreamWriter(fileName))
        {
            if (fileName.EndsWith(".txt"))
            {
                newFile.WriteLine("Date | Prompt | Entry");

                foreach (var entry in _entries)
                {
                    newFile.WriteLine($"{entry._date} | {entry._prompt} | {entry._entry}");
                }
                Console.WriteLine("Document saved....");
            }

            else if (fileName.EndsWith(".csv"))
            {
                newFile.WriteLine("Date,Prompt,Entry");

                foreach (var entry in _entries)
                {
                    newFile.WriteLine($"\"{entry._date}\",\"{entry._prompt}\",\"{entry._entry}\"");
                }
                Console.WriteLine("Document saved....");
            }
            
            else
            {
                Console.WriteLine("File not supported, try again....");
            }
        }
    }

    public void LoadEntries()
    {
        Console.Clear();
        Console.WriteLine("Enter the name of the file you wish to open: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found. Please try again.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);

        if (fileName.EndsWith(".csv")) //exceeding requirements - option to load and save csv files
        {
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[]parts = line.Split(",");
                
                string loadDate = parts[0].Trim('"');
                string loadPrompt = parts[1].Trim('"');
                string loadEntry = parts[2].Trim('"');

                var entry = new Entry();
                entry._prompt = loadPrompt;
                entry._entry = loadEntry;
                entry._date = loadDate;

                _entries.Add(entry);
            }
        }

        else if (fileName.EndsWith(".txt"))
        {
            for(int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[]parts = line.Split('|');

                string loadDate = parts[0].Trim();
                string loadPrompt = parts[1].Trim();
                string loadEntry = parts[2].Trim();

                var entry = new Entry();
                entry._prompt = loadPrompt;
                entry._entry = loadEntry;
                entry._date = loadDate;

                _entries.Add(entry);
            }
        }
        Console.WriteLine("Entries loaded...");

    }
}