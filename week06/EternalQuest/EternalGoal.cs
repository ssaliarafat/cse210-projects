// EternalGoal class
using System;

    public class EternalGoal : Goal  // Inheriting attributes
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override int RecordEvent()
        {
            // always awards points and never completes
            return PointsPerEvent;
        }

        // Overriding our methods
        public override bool IsComplete()
        {
            return false; // eternal goals never complete
        }

        public override string GetStringRepresentation()
        {
            return "[∞]"; // infinity symbol to indicate repeating
        }
        public override string GetDetailsString()
        {
            return $"{Name} ({Description}) - {PointsPerEvent} points";
        }


        public override string ToSaveString()
        {
            // Format: Eternal|name|description|points
            return $"Eternal|{Escape(Name)}|{Escape(Description)}|{PointsPerEvent}";
        }

        private static string Escape(string s) => s.Replace("|", "¦");
        public static string Unescape(string s) => s.Replace("¦", "|");

        public static EternalGoal FromSaveParts(string[] parts)
        {
            // parts: [Eternal, name, description, points]
            var name = Unescape(parts[1]);
            var desc = Unescape(parts[2]);
            var points = int.Parse(parts[3]);
            return new EternalGoal(name, desc, points);
        }
    }
