using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var Job1 = new Job();
        var Job2 = new Job();

        Job2._company = "Microsoft";
        Job2._jobTitle = "Supervisor";
        Job2._startYear= 2021;
        Job2._endYear= 2024;

        Job1._company = "Apple";
        Job1._jobTitle = "Software Development";
        Job1._startYear= 2017;
        Job1._endYear= 2021;
        
        var Resume = new Resume();
        Resume._name = "Efrain O";
        Resume._jobs.Add(Job1);
        Resume._jobs.Add(Job2);

        Resume.Display();
    }
}