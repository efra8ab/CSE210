public class ListingActivity : Activity
{
    private List<string> prompts;

    public ListingActivity()
    {
        name = "Listing Activity";
        description = "List as many things as you can.";
        prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.Clear();

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowCountDown(5); 

        Console.WriteLine("Start listing items. Type 'done' to finish early.");

        int count = 0;
        var startTime = DateTime.Now;

        
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"Total items listed: {count}");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return prompts[rand.Next(prompts.Count)];
    }
}

