using System;

class Program
{
    static void Main(string[] args)
    {   
        DisplayWelcome();
        string username = PromptUserName();
        int favoriteNum = PromptUserNumber();
        int sqrdNum = SquareNumber(favoriteNum);
        DisplayResult(username, sqrdNum);
    }

    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your username?: ");
            string username = Console.ReadLine();
            return username;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number?: ");
            string userInput = Console.ReadLine();
            int favoriteNum = int.Parse(userInput); 
            return favoriteNum;
        }

        static int SquareNumber(int favoriteNum)
        {
            int sqrdNum = favoriteNum * favoriteNum;
            return sqrdNum;
        }

        static void DisplayResult(string username, int sqrdNum)
        {
            Console.WriteLine($"{username}, the square of your number is {sqrdNum}");
        }
}