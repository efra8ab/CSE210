
public class Entry
{
    public string _prompt;
    public string _entry;
    public string _date;

    public Entry()
    {
        _date = DateTime.Now.ToString("MM-dd-yyyy");
    }

    public void Display()
    {
        Console.WriteLine($"{_prompt}:");
        Console.WriteLine($"({_date}) -> {_entry}");
    }
}