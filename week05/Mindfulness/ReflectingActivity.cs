public class ReflectingActivity : Activity
{
    private Random _random = new Random();
    private List<string> _questions = new List<string>
    {
        "Why was this experience menaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What is your favority part about this experience?",
        "What did you learn about yourself through this experience?",
    };
    private List<string> _prompts = new List<string>
    {
        "---Think of a time when you did something that seemed impossible---",
        "---Think of a time when you helped someone during a challening time---",
        "---Think of a time when you did something for the first time",
        "---Think of a time when you learned something new",
        "---Think of a time when you visited a new place",
    };

    public ReflectingActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    public string GetRandomPrompt()
    {
        int promptIndex = _random.Next(_prompts.Count);
        return _prompts[promptIndex];
    }

    public string GetRandomQuestion()
    {
        int questionIndex = _random.Next(_questions.Count);
        return _questions[questionIndex];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"\n{GetRandomPrompt()}");
    }

    public void DisplayQuestions()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"\n{GetRandomQuestion()}");
            ShowSpinner(5);
        }
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        DisplayPrompt();

        Console.WriteLine("\nWhen you have something in mind, press Enter to continue...");
        Console.ReadLine();

        Console.Clear();    
        Console.WriteLine("Now ponder on each of the following questions and your experience.");
        ShowSpinner(10);

        DisplayQuestions();

        DisplayEndingMessage(); 
    }
}