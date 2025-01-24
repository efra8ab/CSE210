using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        bool exit = true;

        while (exit)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Journal program!");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. View Entries");
            Console.WriteLine("3. Save Entries");
            Console.WriteLine("4. Load Entries");
            Console.WriteLine("5. Exit");
            Console.Write("Please choose an option: ");
            string option = Console.ReadLine();
            
            switch (option)
            {
                case "1":
                    Console.WriteLine("This is option 1");
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("This is option 2");
                    Console.ReadLine();
                    break;

                case "3":
                    Console.WriteLine("This is option 3");
                    Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine("This is option 4");
                    Console.ReadLine();
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    exit = false;
                    break;

                default:
                    Console.WriteLine("Incorrect option, please try again...");
                    Console.ReadLine();
                    break;   
            }

        }
    }
}