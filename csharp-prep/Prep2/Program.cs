using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? %");
        string GradePercentage = Console.ReadLine();

        int grade = int.Parse(GradePercentage);
        string letter;
        string modifier = "";

        if (grade >= 90)
        {letter = "A";}
        else if (grade >= 80)
        {letter = "B";}
        else if (grade >= 70)
        {letter = "C";}
        else if (grade >= 60)
        {letter = "D";}
        else
        {letter = "F";}

        if (letter != "F" && grade < 97)
        {
            int LastDigit = grade % 10;

            if (LastDigit >= 7)
            {modifier = "+";}

            else if (LastDigit <= 3)
            {modifier = "-";}
        }

        Console.WriteLine($"\nYou've got {letter}{modifier}");

        if (grade < 70)
        {Console.WriteLine("Unfortunately, you have failed the class. Next luck next time ");}
        else
        {Console.WriteLine("Congratulations, You have passed this class!");}
    }
}