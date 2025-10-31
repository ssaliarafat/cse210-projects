using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a list to store the numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break; // stop asking when user enters 0
            }

            numbers.Add(number);
        }

        // Computing the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Computing the average
        double average = (double)sum / numbers.Count;

        // Finding the maximum number
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Displaying the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}
