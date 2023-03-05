using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbersList = new List<int>();
        Console.WriteLine("Please input numbers below. Enter '0' when finished.");
        int input = -1;

        while (input != 0) 
        {
            input = int.Parse(Console.ReadLine());
            if (input != 0) {numbersList.Add(input);}
        }
        int sum = 0;
        int largestNumber = 0;
        foreach (int i in numbersList)
        {
            sum += i;
            if (i > largestNumber) {largestNumber = i;}
        }
        Console.WriteLine($"There were {numbersList.Count} numbers in your list.");
        Console.WriteLine($"The sum of the numbers is {sum}.");
        int average = sum / numbersList.Count;
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The largest number is {largestNumber}.");

    }
}