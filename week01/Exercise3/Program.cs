using System;

class Program
{
    static void Main(string[] args)
    {

        Random rnd = new Random();
        int magicNumber = rnd.Next(1, 101); 
        int guess;

        Console.WriteLine("I have chosen a magic number between 1 and 100. Try to guess it!");

        Console.Write("What is your guess? ");
        string input = Console.ReadLine();

        while (!int.TryParse(input, out guess))
        {
            Console.Write("Please enter a valid integer: ");
            input = Console.ReadLine();
        }

        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }

            Console.Write("What is your guess? ");
            input = Console.ReadLine();
            while (!int.TryParse(input, out guess))
            {
                Console.Write("Please enter a valid integer: ");
                input = Console.ReadLine();
            }
        }

        Console.WriteLine("You guessed it! Well done.");
    }
}
