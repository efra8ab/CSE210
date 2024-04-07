public class ReflectingActivity : Activity
{
    private List<string> prompts;
    private List<string> questions;

    public ReflectingActivity()
    {
        name = "Reflecting Activity";
        description = "Reflect on your past experiences.";
        prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public override void Run()
    {   
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();

        Console.WriteLine("Now answer the following questions: ");
        Console.ReadLine();
        Console.Clear();

        var selectedQuestions = GetRandomQuestions(3); 


        foreach (var question in selectedQuestions)
        {
            Console.WriteLine(question);
            ShowSpinner(5); 
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return prompts[rand.Next(prompts.Count)];
    }

    private List<string> GetRandomQuestions(int count)
    {
        Random rand = new Random();
        var selectedQuestions = new HashSet<string>();
        while (selectedQuestions.Count < count)
        {
            selectedQuestions.Add(questions[rand.Next(questions.Count)]);
        }
        return selectedQuestions.ToList();
    }
}
