public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    protected Activity()
    {
        
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Activity: {name}");
        Console.WriteLine(description);
        Console.Write("Please enter the duration of the activity in seconds: ");
        duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowCountDown(3);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done! You have completed the activity.");
        Console.WriteLine($"{name} completed for {duration} seconds.");
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("|");
            Thread.Sleep(250);
        }
        Console.WriteLine();
    }

    protected void ShowCountDown(int seconds)
    {
        for (int sec = seconds; sec > 0; sec--)
        {
            Console.Write($"{sec} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void Run();
}
