using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> Numbers = new List<int>();
        int Number = -10000;
        Console.Clear();
        Console.WriteLine("Enter a number (enter '0' once you are done) \n-->");

        while (Number != 0)
        {
            Console.WriteLine("Enter number: ");
            string StrNumber = Console.ReadLine();
            Number = int.Parse(StrNumber);  

            if (Number != 0)
            {Numbers.Add(Number);}
        }

        int SumList = Numbers.Sum();
        double AvgList = Numbers.Average();
        int MaxList = Numbers.Max();
        int MinPositiveNum = 1000000;
        Numbers.Sort();

        foreach (int Num in Numbers)
        {
            if (Num < MinPositiveNum && Num > 0)
            {MinPositiveNum = Num;}
        }

        Console.Clear();
        Console.WriteLine($"The sum of the elements of your list is: {SumList}");
        Console.WriteLine($"The average of the elements of your list is: {AvgList}");
        Console.WriteLine($"The Largest number of the elements of your list is: {MaxList}");
        Console.WriteLine($"The Smallest number of the elements of your list is: {MinPositiveNum}");
        Console.WriteLine("Sorted list in ascending order: ");

        foreach (int Num in Numbers)
        {Console.WriteLine(Num);}
    }
}