using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!!!!");
        int x;
        x = 3;
        Console.WriteLine(x);

        Console.WriteLine("What is your favorite color? ");
        string color = Console.ReadLine();
        Console.WriteLine($"Your favorite color is {color}");
        int y = 1;

        if (x > y)
        {
            Console.WriteLine("graeater");
        }
        
    }
}