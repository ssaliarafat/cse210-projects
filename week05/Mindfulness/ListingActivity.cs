using System;
using System.Collections.Generic;

 public class ListingActivity : Activity
    {
        private List<string> prompts = new List<string>()   // Our list attribute for storing prompts
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

    public ListingActivity() : base(           // Inheriting common attributes
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

    public void Run()                     // Our Run Method with behaviors for this class
    {
        DisplayStartingMessage();

        Random rand = new Random();
        int duration = GetDuration();

        Console.WriteLine("\nList Prompt:");     // Displaying prompts
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);

        Console.WriteLine("\nGet ready...");
        Countdown(5);
        Console.WriteLine("\nStart listing items:");

        List<string> items = new List<string>();        // Adding User inputs to a list for counting
        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            items.Add(input);
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
        DisplayEndingMessage();
    }
}
