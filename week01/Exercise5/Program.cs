using System;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    {
        Console.Clear();
        Console.Write("Write down your username: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Clear();
        Console.Write("Write down your favorite number: ");
        string strUserNumber = Console.ReadLine();
        int userNumber = int.Parse(strUserNumber);
        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int squareNumber = userNumber * userNumber;
        return squareNumber;
    }

    static void DisplayResult(string userName, int SquareNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {SquareNumber}");
    }

    static void Main(string[] args)
    {
        Console.Clear();
        DisplayWelcome();
        string username = PromptUserName();
        int userNumber = PromptUserNumber();
        int SquareNum = SquareNumber(userNumber);
        DisplayResult(username, SquareNum);

    }
}