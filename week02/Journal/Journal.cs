using System.IO;

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
    }
}