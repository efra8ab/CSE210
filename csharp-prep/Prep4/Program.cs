using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {   
        List<int> numbers = new List<int>();
        
        int newNumber = 1;

        Console.WriteLine("Enter a list of number, type 0 when finished.");

        while (newNumber != 0)
        {
            Console.Write("Next number ");
            string userInput = Console.ReadLine();
            newNumber = int.Parse(userInput);
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        }

        int sumOfList = 0; 
        float avgOfList = 0;
        int minOfList = int.MaxValue;
        int maxOfList = int.MinValue;


        foreach(int number in numbers)
        {   
            //sum of all the elements on the list
            sumOfList += number;
            Console.WriteLine(number);

            //finding the largest number on the list
            if (number > maxOfList)
            {
                maxOfList = number;
            }

            //finding the smallest number on the list
            else if (number < minOfList && number > 0)
            {
                minOfList = number;
            }
        }

        //obtaining the average of the numbers inside the list
        avgOfList = (float)sumOfList / numbers.Count;
        
        Console.WriteLine($"\nSum of the list: {sumOfList}");
        Console.WriteLine($"Avg of the list: {avgOfList}");
        Console.WriteLine($"Largest number of the list: {maxOfList}");
        Console.WriteLine($"Smallest positive number of the list: {minOfList}");

        //sorting the list
        numbers.Sort();

        //printing the sorted  list
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }


    }
}