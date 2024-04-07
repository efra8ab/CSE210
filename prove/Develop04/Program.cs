using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");
            string choice = Console.ReadLine();

            Activity activity = null;
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    activity = new BreathingActivity();
                    break;
                case "2":
                    Console.Clear();
                    activity = new ListingActivity();
                    break;
                case "3":
                    Console.Clear();
                    activity = new ReflectingActivity();
                    break;
                case "4":
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice, please try again.");
                    continue;
            }
            activity.Run();
            Console.WriteLine("\nPress Enter to return to the main menu...");
            Console.ReadLine();
        }
    }
}
