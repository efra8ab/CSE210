using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public Prompt _randPrompt;

    public Entry()
    {
        _randPrompt = new Prompt();
    }

    public void NewEntry()
    {
        _promptText = _randPrompt.Random_prompt();

        Console.WriteLine(_promptText);
        Console.Write("> "); 
        _entryText = Console.ReadLine();

        Console.WriteLine("Write today's date");
        Console.Write("> ");
        _date =  Console.ReadLine();
    }

    public string DisplayText()
    {
        return $"\nDate: {_date} - Prompt: {_promptText}\n-->: {_entryText}\n";   
    } 

}