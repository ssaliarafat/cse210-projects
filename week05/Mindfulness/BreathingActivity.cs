using System;

public class BreathingActivity : Activity        // Inheriting from our parent class
{
  public BreathingActivity() : base(            // Accessing _name and _description attributes
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }
    
    public void Run()                       // The Run method having its own behavior
    {
        DisplayStartingMessage();
        int duration = GetDuration();

        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            Console.Write("\nBreathe in...");
            Countdown(4);

            Console.Write("\nBreathe out...");
            Countdown(4);
        }

        DisplayEndingMessage();
    }
}



