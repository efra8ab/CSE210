using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {   
        string playAgain = "yes";
        do
        {   
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int counter = 1;

            Console.WriteLine($"What is the Magic number? {magicNumber}");
            Console.Write("Make a guess: ");
            string guess = Console.ReadLine();
            int intGuess = int.Parse(guess);    

            while (magicNumber != intGuess)
            {
                counter += 1;

                if (magicNumber < intGuess)
                {Console.WriteLine("Lower");}
                else if (magicNumber > intGuess)
                {Console.WriteLine("Higher");}

                Console.Write("Make a guess: ");
                guess = Console.ReadLine();
                intGuess = int.Parse(guess);
            }

            Console.WriteLine("\nYou guessed it!");
            Console.WriteLine($"only took you {counter} tries");

            Console.WriteLine("\nDo you want to play again? ");
            playAgain = Console.ReadLine();

        }while (playAgain == "yes");


    }
}