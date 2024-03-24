using System;
using System.Collections.Generic;
using System.Security.Cryptography;

public class Prompt
{
    public List<string> _prompts = new List<string>();
    public Random _random;

    public Prompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");

        _random = new Random();

    }

    public string Random_prompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];

    }
}