using System;
using System.Xml.Serialization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        Reference reference = new Reference("Nephi", 1, 1);
        
        string text = "I, Nephi, having been aborn of bgoodly cparents, therefore I was dtaught somewhat in all the learning of my father; and having seen many eafflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a frecord of my proceedings in my days.";

        Console.Clear();
        Scripture scripture = new Scripture(reference, text);

        Console.WriteLine("Press Enter to hide a word: ");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine(reference.GetDisplayText());

        while (!scripture.IsCompletelyHidden())
        {
            Console.ReadLine();
            scripture.HideRandomWords(1);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine(reference.GetDisplayText());
        }
        
        Console.Clear();
        Console.WriteLine("\nThe entire passage is now hidden. Press Enter to exit.");
        Console.ReadLine();
    }
}