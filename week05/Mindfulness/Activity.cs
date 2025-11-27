using System;
using System.Threading;

public class Activity         // Our common attributes
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)   // The constructor
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()           // Our Common methods
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine(_description);
        Console.Write("\nEnter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);

        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }

    public int GetDuration()
    {
        return _duration;
    }

    // Spinner Animation
    public void ShowSpinner(int seconds)
    {
        string[] spin = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < end)
        {
            Console.Write(spin[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i = (i + 1) % 4;
        }
    }

    // Countdown Animation
    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
