using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Magic Number game! ");
        Console.WriteLine("Can you guess the Magic Number?");
        Random RanGen = new Random();
        bool KeepPlaying = false;

        while(!KeepPlaying)
        {
        
        int MagicNumber = RanGen.Next(0, 100);
        bool valid = false;
        int attempts = 0;

        while(!valid)
        {
        attempts += 1;
        Console.Write("What is your guess?: ");
        string Strguess = Console.ReadLine();
        int guess = int.Parse(Strguess); 

        if (guess < MagicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > MagicNumber)
        {
            Console.WriteLine("Lower");
        }
        else if (guess == MagicNumber)
        {
            Console.Clear();
            Console.WriteLine("You guessed the Magic  Number!");
            Console.WriteLine($"It only took you {attempts} attempts");
            valid = true;
        }
        }
        
        Console.Write("Do you want to play again? ");
        string PlayAgain = Console.ReadLine().ToLower();

        if (PlayAgain == "yes")
        {Console.Clear();}
        else if (PlayAgain == "no")
        {
            Console.WriteLine("Thank you for playing with us!");
            KeepPlaying = true;}
        }
    }
}