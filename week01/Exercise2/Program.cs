using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Write down your grade percentage: ");
        string strGrade = Console.ReadLine();
        int grade = int.Parse(strGrade);

        string letterGrade = "";
        string sign = "";

        int lastDigit = grade % 10;

        if (lastDigit >= 7 && grade < 97)
        {sign = "+";}
        else if (lastDigit < 3)
        {sign = "-";}

        if (grade >= 90) // A
        {
            letterGrade = "A" + sign;
        } 

        else if (grade >= 80) // B
        {
            letterGrade = "B" + sign;
        }

        else if (grade >= 70) // C
        {
            letterGrade = "C" + sign;
        }

        else if (grade >= 60) // D
        {
            letterGrade = "D" + sign;
        }

        else if (grade < 60) // F
        {
            letterGrade = "F";
        }

        else
        {   
            Console.Clear();
            Console.WriteLine("Please enter a valid percentage!");
        }

        if (grade >= 70)
        {
            Console.Clear();
            Console.WriteLine($"Letter grade: {letterGrade}\nCongratulations!, you have passed the course");
        }
        else 
        {
            Console.Clear();
            Console.WriteLine($"Letter grade: {letterGrade}\nUnfortunately, you have not passed the course");
        }

    }
}