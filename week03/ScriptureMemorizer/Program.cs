using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<(Reference, string)> scriptures = new List<(Reference, string)>
        {
            (new Reference("Moses", 1, 39),"For behold, this is my work and my glory to bring to pass the immortality and eternal life of man."),
            (new Reference("Isaiah", 55, 8, 9), "For my thoughts are not your thoughts, neither are your ways my ways, saith the Lord. \nFor as the heavens are higher than the earth, so are my ways higher than your ways, and my thoughts than your thoughts."),
            (new Reference("Mosiah", 2, 17), "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.")
        };

        Random rand = new Random();
        
        while (true)
        {   
            Console.Clear();
            Console.WriteLine("Welcome to the Scripture Memorizer");

            string strDifficulty;

            do 
            {
                Console.WriteLine("-----Select a difficulty-----");
                Console.WriteLine("1. Easy (1 word)");
                Console.WriteLine("2. Medium (2 words)");
                Console.WriteLine("3. Hard (3 words)");
                strDifficulty = Console.ReadLine();
            }
            while (strDifficulty != "1" && strDifficulty != "2" && strDifficulty != "3");
            
            int difficulty = int.Parse(strDifficulty);

            Console.Clear();
            Console.WriteLine("Press enter to begin memorizing");
            Console.ReadLine();

            var randomScript = scriptures[rand.Next(scriptures.Count)];
            Scripture scripture = new Scripture(randomScript.Item1, randomScript.Item2);

            while(true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                break;

                scripture.HideRandomWords(difficulty);

                if (scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine("All words are hidden!, press enter to exit");
                    break;
                }
            }

            string response = Console.ReadLine();

            do
            {
                Console.WriteLine("Do you want to memorize another scripture? (Y or N)");
                response = Console.ReadLine().ToLower();
            }
            while (response != "y" && response != "n");

            if (response == "n")
            {   
                Console.Clear();
                Console.WriteLine("Goodbye!");
                break;
            }
        }
    }
}