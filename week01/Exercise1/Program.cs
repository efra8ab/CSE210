using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("What is your first name?");
        string name = Console.ReadLine();
        
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

        Console.Clear();
        Console.WriteLine($"Your name is {lastName}, {name} {lastName}.");
    }
}