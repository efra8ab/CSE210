
using System.ComponentModel.DataAnnotations;

public class PromptGenerator
{
    public List<string> _prompts;
    public Random _random = new Random();

    public PromptGenerator()
    {
        _prompts = new List<string>() {
            "What is something new I learned today?",
            "What moment from today made me smile the most?",
            "What is one thing I accomplished today that I am proud of?",
            "What was the most challenging part of my day, and how did I handle it?",
            "If I could change one thing about today, what would it be?",
            "What is one thing I am grateful for today?",
            "What is a small win I experienced today?",
            "Who or what brought me joy today?",
            "What is one thing I'm looking forward to tomorrow?",
            "What did I do today to move closer to my goals?",
            "How did I step outside of my comfort zone today?",
            "What is one area where I can improve based on today's experiences?",
            "What is a habit I worked on today, and how did it go?",
            "Who did I connect with today, and what did we talk about?",
            "Who inspired me today, and why?",
            "How did I show kindness to someone today?"                    
        };
    }
    public string RandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}