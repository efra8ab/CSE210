using System;
using System.Reflection;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string stgPercent = Console.ReadLine();
        int intPercent = int.Parse(stgPercent);
        string letter = "";

        int remainder = intPercent % 10;
        string sign =  "";

        if (remainder >= 7 && intPercent < 97 && intPercent >= 60)
        {
            sign = "+";
        }
        else if (remainder < 3 && intPercent >= 60)
        {
            sign = "-";
        }

        if (intPercent >= 90 && intPercent < 100)
        {
            letter = "A";
        }
        else if (intPercent >= 80 && intPercent < 90)
        {
            letter = "B";
        }
        else if (intPercent >= 70 && intPercent < 80)
        {
            letter = "C";
        }
        else if (intPercent >= 60 && intPercent < 70)
        {
            letter = "D";
        }
        else if (intPercent < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("The value entered is incorrect ");
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (intPercent >= 70)
        {
            Console.WriteLine("You passed the class!!");
        }
        else
        {
            Console.WriteLine("You have failed the class, try again next time");
        }
    
    }
}