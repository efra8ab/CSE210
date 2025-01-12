using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Random random= new Random();
        int magicNumber = random.Next(0, 100);

        while (true)
        {

            Console.Write("Take a guess: ");
            string strGuess = Console.ReadLine();
            int guess = int.Parse(strGuess);

            if (guess < magicNumber)
            {Console.WriteLine("higher!");}
            else if (guess > magicNumber)
            {Console.WriteLine("lower!");}
            else
            {Console.WriteLine("You got it!"); break;}
        }
    }
}