using System;

//exceeding requirements
//added an option to create .txt or .csv files and load these two 
//handled errors for incorrect selection or file type

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        bool exit = true;
        var journal = new Journal();

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

            PromptGenerator randomPrompt = new PromptGenerator();
            
            switch (option)
            {
                case "1":
                    Console.Clear();
                    journal.AddEntry(randomPrompt);
                    Console.ReadLine();
                    break;

                case "2":
                    Console.Clear();
                    journal.ViewEntries();
                    Console.ReadLine();
                    break;

                case "3":
                    journal.SaveEntries();
                    Console.ReadLine();
                    break;

                case "4":
                    journal.LoadEntries();
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