using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        DisplayWelcome();
        
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int SquaredNumber = SquareNumber(userNumber);
        
        DisplayResult(userName, SquaredNumber);
    }

    static void DisplayWelcome()
    { Console.WriteLine("Welcome to the Program!"); }

    static string PromptUserName()
    { Console.Write("What is your name? ");
      string userName = Console.ReadLine();
      return userName;}

    static int PromptUserNumber()
    { Console.Write("What is your favorite numer? ");
      string Number = Console.ReadLine();
      int userNumber = int.Parse(Number);
      return userNumber;}

    static int SquareNumber(int userNumber)
    { int SquaredNumber = userNumber * userNumber;
      return SquaredNumber;}

    static void DisplayResult(string userName, int SquaredNumber)
    { Console.WriteLine($"{userName}, the square of your number is {SquaredNumber}"); }
}