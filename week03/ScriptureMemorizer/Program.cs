using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer");
        
        Reference reference1 = new Reference("Alma", 2, 3);
        Scripture scripture= new Scripture(reference1, "Hola, Hola, Hola, Hola, Hola");

        while(true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");
            string userInput = Console.ReadLine();
            
            if (userInput.ToLower() == "quit")
            break;

            scripture.HideRandomWords(1);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("All words are hidden!, press enter to exit");
                Console.ReadLine();
                break;
            }
        }
    }
}