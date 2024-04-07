public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        name = "Breathing Activity";
        description = "Focus on breathing in and out slowly.";
    }

    public override void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < duration; i += 4) 
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(2);
            Console.WriteLine("Breathe out...");
            ShowSpinner(4);
        }
        DisplayEndingMessage();
    }
}
