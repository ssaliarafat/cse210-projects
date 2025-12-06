using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static List<Goal> goals = new List<Goal>(); 
    private static int totalScore = 0;
    private static int level = 1;
    private const string SaveFile = "eternal_quest_save.txt";

    static void Main(string[] args)
    {
        Console.Title = "Eternal Quest";

        // The Program Menu
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine($"Score: {totalScore}   Level: {level}");
            Console.WriteLine("1) Create a new goal");
            Console.WriteLine("2) List goals");
            Console.WriteLine("3) Record Event");
            Console.WriteLine("4) Save goals");
            Console.WriteLine("5) Load goals");
            Console.WriteLine("6) Quit");
            Console.Write("Select a choice from the menu: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); Pause(); break;
                case "3": RecordEvent(); Pause(); break;
                case "4": Save(); Pause(); break;
                case "5": Load(); Pause(); break;
                case "6": running = false; break;
                default: Console.WriteLine("Invalid choice."); Pause(); break;
            }
        }
    } 

    // My Methods from the classes
        static void CreateGoal()
        {
            Console.Clear();
            Console.WriteLine("Choose goal type:");
            Console.WriteLine("1) Simple goal");
            Console.WriteLine("2) Eternal goal");
            Console.WriteLine("3) Checklist goal");
            Console.Write("Type: ");
            var t = Console.ReadLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Description: ");
            string desc = Console.ReadLine();
            Console.Write("Points per event: ");
            int points = int.Parse(Console.ReadLine());

            if (t == "1")
            {
                goals.Add(new SimpleGoal(name, desc, points));
            }
            else if (t == "2")
            {
                goals.Add(new EternalGoal(name, desc, points));
            }
            else if (t == "3")
            {
                Console.Write("Target: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points on completion: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
            }
            else
            {
                Console.WriteLine("Unknown type");
                Pause();
                return;
            }

            Console.WriteLine("Goal created.");
            Pause();
        }

        static void ListGoals()
        {
            Console.Clear();
            if (goals.Count == 0)
            {
                Console.WriteLine("No goals yet.");
                return;
            }

            Console.WriteLine("Goals:");
            for (int i = 0; i < goals.Count; i++)
            {
                var g = goals[i];
                Console.WriteLine($"{i+1}) {g.GetStringRepresentation()} {g.Name} - {g.Description}");
            }
        }

        static void RecordEvent()
        {
            Console.Clear();
            if (goals.Count == 0)
            {
                Console.WriteLine("No goals to record.");
                return;
            }

            ListGoals();
            Console.Write("Choose goal number to record an event for: ");
            if (!int.TryParse(Console.ReadLine(), out int idx) || idx < 1 || idx > goals.Count)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }

            var goal = goals[idx - 1];
            int awarded = goal.RecordEvent();
            if (awarded > 0)
            {
                totalScore += awarded;
                Console.WriteLine($"You gained {awarded} points!");
                CheckLevelUp();
            }
            else
            {
                Console.WriteLine("No points awarded (maybe it was already completed).");
            }

            Console.WriteLine($"Total score: {totalScore} (Level {level})");
        }

        static void Save()
        {
            using (var writer = new StreamWriter(SaveFile))
            {
                // First line: score and level
                writer.WriteLine($"{totalScore}|{level}");
                // Then one line per goal using ToSaveString
                foreach (var g in goals)
                {
                    writer.WriteLine(g.ToSaveString());
                }
            }
            Console.WriteLine($"Saved to {SaveFile}");
        }

       static void Load()
{
    if (!File.Exists(SaveFile))
    {
        Console.WriteLine("Save file not found.");
        return;
    }

    goals.Clear();
    using (var reader = new StreamReader(SaveFile))
    {
        string first = reader.ReadLine();
        if (!string.IsNullOrEmpty(first))
        {
            var parts = first.Split('|');
            if (parts.Length >= 2)
            {
                totalScore = int.Parse(parts[0]);
                level = int.Parse(parts[1]);
            }
        }

        string line;
        while ((line = reader.ReadLine()) != null)
        {
            var parts = line.Split('|');
            if (parts.Length == 0) continue;
            var type = parts[0];
            try
            {
                switch (type)
                {
                    case "Simple":
                        goals.Add(SimpleGoal.FromSaveParts(parts));
                        break;
                    case "Eternal":
                        goals.Add(EternalGoal.FromSaveParts(parts));
                        break;
                    case "Checklist":
                        goals.Add(ChecklistGoal.FromSaveParts(parts));
                        break;
                    default:
                        // ignore unknown lines
                        break;
                }
            }
            catch
            {
                // ignore parse errors for robustness
            }
        }
    }

    Console.WriteLine("Loaded save file.");
}

        static void CheckLevelUp()
        {
            // Simple level system it every 1000 points increases level by 1
            int newLevel = (totalScore / 1000) + 1;
            if (newLevel > level)
            {
                level = newLevel;
                Console.WriteLine($"*** Level Up! You are now level {level}! ***");
            }
        }

        static void Pause()
        {
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
}    