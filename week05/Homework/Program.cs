using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        MathAssignment mathAssignment= new MathAssignment("Efrain O", "Fractions", "12.b", "13 - 15");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine("\n");

        WrittingAssignment writtingAssignment = new WrittingAssignment("Eric N", "WW2", "External Causes");
        Console.WriteLine(writtingAssignment.GetWrittingInformation());

    }
}