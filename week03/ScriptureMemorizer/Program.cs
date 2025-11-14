using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating the scripture reference new object
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        // The scripture text assigned with the variable text
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";

        // Create the scripture object with two parameters for reference and scripture text
        Scripture scripture = new Scripture(reference, text);

        // Main loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to end.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ended.");
                break;
            }
        }
    }
}
