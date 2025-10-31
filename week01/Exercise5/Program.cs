using System;

class Program
{
    // Displaying the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Asking for user name and returns it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Asking for user favorite number and returns it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Getting a number and returns the square of that number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Getting the user's name and squared number and display them
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

    // The Main function that calls everything
    static void Main(string[] args)
    {
        DisplayWelcome();

        // Calling all my functions and store them into variables to be used in the display function
        string userName = PromptUserName();
        
        int favoriteNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(favoriteNumber);  

        DisplayResult(userName, squaredNumber);
    }
}
