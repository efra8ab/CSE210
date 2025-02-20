public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you breathing in and out slowly.\n Clear your mind and focus on your breathing...")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime endtime = DateTime.Now.AddSeconds(_duration);

        Console.Clear();
        Console.WriteLine("Let's begin");

        while (DateTime.Now < endtime)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountDown(5);

            Console.WriteLine("Breathe out...");
            ShowCountDown(5);
        }

        DisplayEndingMessage();
    }
}