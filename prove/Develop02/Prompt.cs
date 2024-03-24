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
        _prompts.Add("What lesson did I learn today that I can apply in the future?");
        _prompts.Add("Which moment today was the most peaceful?");
        _prompts.Add("What am I most thankful for at this point in my life?");
        _prompts.Add("How did I challenge myself today?");
        _prompts.Add("What was the funniest thing that happened today?");
        _prompts.Add("Who did I help today and how did it make me feel?");
        _prompts.Add("What progress did I make on my goals today?");
        _prompts.Add("What am I looking forward to tomorrow?");
        _prompts.Add("How did I take a step towards a healthier lifestyle today?");
        _prompts.Add("What was a significant conversation I had today and why was it meaningful?");

        _random = new Random();

    }

    public string Random_prompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];

    }
}