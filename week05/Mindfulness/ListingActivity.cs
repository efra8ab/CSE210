public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int promptIndex = rand.Next(_prompts.Count);

        Console.WriteLine("\nList as many responses as you can to the following prompt: ");
        Console.WriteLine($"--- {_prompts[promptIndex]}");
    }

    private List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine("\nStart listing items! Press Enter after each one");

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string entry = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(entry))
                {
                    userList.Add(entry);
                }
            }
        }
        return userList;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        
        GetRandomPrompt();
        Console.WriteLine("You will begin in: ");
        ShowCountDown(10);

        List<string> userList = GetListFromUser();
        _count = userList.Count;

        Console.Clear();   
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }
}
