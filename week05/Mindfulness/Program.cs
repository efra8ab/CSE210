using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflection Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Finish Session");
            Console.WriteLine("\nSelect one option: ");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;
                case "3":
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid options. Press Enter to continue...");
                    Console.ReadLine();
                    break;
            }
            
        }
    }
}