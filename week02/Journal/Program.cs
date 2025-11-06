using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Creating instances from the journal class and the prompt generator
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();

      //Displaying and Looping the Menu list
        bool programRunning = true;

        while (programRunning)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            if (choice == "1")    //user selections
            {
                string prompt = generator.GetRandomPrompt(); //generating a random prompt from our prompt generator class
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();    //new entry instance with all the values
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._PromptText = prompt;
                newEntry._entryText = response;

                journal.AddEntry(newEntry); //Adding this new instance to our journal with our AddEntry method from the journal class
            }
            else if (choice == "2")
            {
                journal.DisplayAll();  //Displaying all the saved entries with the journal class method of display all
            }
            else if (choice == "3") //Saving to a file
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);       //Method used
                Console.WriteLine("Journal saved!");
            }
            else if (choice == "4") //Loading the saved file
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);       //method used
                Console.WriteLine("Journal loaded!");
            }
            else if (choice == "5")  //Terminating our program
            {
                programRunning = false;
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
