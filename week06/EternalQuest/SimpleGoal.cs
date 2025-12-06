// The SimpleGoal Class
using System;

    public class SimpleGoal : Goal // inheriting all the attributes
    {
        private bool _completed;

        public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
        {
            _completed = false;
        }

        // Overriding our Goal Methods for specifically the SimpleGoal class
        public override int RecordEvent() 
        {
            if (_completed)
            {
                // already done - no points
                return 0;
            }
            _completed = true;
            return PointsPerEvent;
        }

        public override bool IsComplete() 
        {
            return _completed;
        }

        public override string GetStringRepresentation()
        {
            return _completed ? "[X]" : "[ ]";
        }
        public override string GetDetailsString()
            {
                return $"{Name} ({Description}) - {PointsPerEvent} points";
            }


        public override string ToSaveString()
        {
            // Format - Simple|name|description|points|completed
            return $"Simple|{Escape(Name)}|{Escape(Description)}|{PointsPerEvent}|{_completed}";
        }

        // helper to escape pipe characters
        private static string Escape(string s) => s.Replace("|", "¦");
        public static string Unescape(string s) => s.Replace("¦", "|");

        // Factory method to load (called from Program)
        public static SimpleGoal FromSaveParts(string[] parts)
        {
            // parts expected: [Simple, name, description, points, completed]
            var name = Unescape(parts[1]);
            var desc = Unescape(parts[2]);
            var points = int.Parse(parts[3]);
            var completed = bool.Parse(parts[4]);
            var g = new SimpleGoal(name, desc, points);
            if (completed) g._completed = true;
            return g;
        }
    }

