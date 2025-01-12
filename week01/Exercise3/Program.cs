using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        

    while (true)
    {   
        Random random= new Random();
        int magicNumber = random.Next(0, 100);

        int counter = 0;

        Console.WriteLine("Welcome to the Magic Number game, lets play!");

        while (true)
        {
            counter += 1;
            Console.Write("Take a guess: ");
            string strGuess = Console.ReadLine();
            int guess = int.Parse(strGuess);

            if (guess < magicNumber)
            {Console.WriteLine("higher!");}
            else if (guess > magicNumber)
            {Console.WriteLine("lower!");}
            else
            {
                Console.Clear();
                Console.WriteLine("You got it!");
                Console.WriteLine($"number of guesses: {counter}");
                Console.WriteLine("Press enter to continue ...");
                Console.ReadLine(); 
                break;
            }
        }
        Console.Clear();
        Console.WriteLine("Do you wish to play again? (y / n)");
        string playAgain = Console.ReadLine().ToLower();

        if (playAgain == "n")
        {
            Console.Clear();
            Console.WriteLine("Thanks for playing!");
            break;
        }
        else if (playAgain != "y")
        {
            Console.Clear();
            Console.WriteLine("Invalid input. Closing game!");
            break;
        }
        Console.Clear();
    }
    }
}