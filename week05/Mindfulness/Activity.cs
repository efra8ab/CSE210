public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the mindfulness program!\n");

        Console.WriteLine("How long, in seconds, would you like for your activity?");
        string strUserDuration = Console.ReadLine();
        _duration = int.Parse(strUserDuration);

        Console.WriteLine("Loading...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(5);

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(7);
    }

    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int spinnerCounter = 0;

        string[] spinnerFrames = {"/", "-", "\\", "|",};

        while (DateTime.Now < endTime)
        {
            Console.Write($"\r{spinnerFrames[spinnerCounter % 4]}");
            spinnerCounter++;
            Thread.Sleep(100);
        }

        Console.Write("\r");
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i}");
            Thread.Sleep(1000);
        }

        Console.WriteLine();
    }


}