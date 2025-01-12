using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.WriteLine("Enter number: ");
            string strNumber = Console.ReadLine();
            int number = int.Parse(strNumber);
            
            if (number != 0)
            {
                numbers.Add(number);
            }
            
            else if (number == 0)
            {
                break;
            }

        }

        //SUM of values
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        //Average
        double avg = (double)sum / numbers.Count;

        //Smallest, positive number
        int min = numbers[0];
        foreach (int number in numbers)
        {
            if (number < min && number > 0) {min = number;}
        }

        //Biggest
        int max = numbers[0];
        foreach(int number in numbers)
        {
            if (number > max) {max = number;}
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min}");
        
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        
    }
}