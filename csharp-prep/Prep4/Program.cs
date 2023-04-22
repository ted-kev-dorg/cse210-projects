using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");


        // \Creation of an empty list
        List<int> numbers = new List<int>();


        // Ask the user for a series of numbers, and append each one to a list. 
        // Stop when they enter 0.

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        string number = Console.ReadLine();
        int numberToAdd = int.Parse(number);

        int total = 0;
        float average = 0;
        int biggestSoFar = 0;
        int smallestSoFar = 9999;

        while (numberToAdd != 0)
        {
            numbers.Add(numberToAdd);
            Console.Write("Enter number: ");
            number = Console.ReadLine();
            numberToAdd = int.Parse(number);
        }

        foreach (var item in numbers)
        {
            total += item;
        }

        average = ((float)total) / numbers.Count;

        foreach (int item in numbers)
        {
            if (item > biggestSoFar)
            biggestSoFar = item;
        }

        foreach (int item in numbers)
        {
            if (item> 0 && item < smallestSoFar)
            {
                smallestSoFar = item;
            }
        }

        

        Console.WriteLine(numbers.Count);
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {biggestSoFar}");
        Console.WriteLine($"The smallest positive number is: {smallestSoFar}");    
        
        numbers.Sort();

        for (int i = 0; i < numbers.Count; i++)
        {
            int numBer = numbers[i];
            Console.WriteLine(numBer);
        }



    }
}