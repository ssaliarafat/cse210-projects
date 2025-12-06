// The ChecklistGoal class
using System;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _bonus;
    private int _currentCount;
    private bool _isComplete;
    
    // constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _currentCount = 0;
        _isComplete = false;
    }
    
    // Overriding our methods
    public override int RecordEvent()
    {
        if (_isComplete) return 0;

        _currentCount++;
        int awarded = PointsPerEvent;

        if (_currentCount >= _target)
        {
            _isComplete = true;
            awarded += _bonus;
        }

        return awarded;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return _isComplete ?
            $"[X] ({_currentCount}/{_target})" :
            $"[ ] ({_currentCount}/{_target})";
    }

    public override string GetDetailsString()
{
    return $"{Name} ({Description}) — {PointsPerEvent} points " +
           $"Completed: {_currentCount}/{_target} | Bonus: {_bonus}";
}


    public override string ToSaveString()
    {
        // The Format is Checklist|name|description|points|target|bonus|current|completed
        return $"Checklist|{Escape(Name)}|{Escape(Description)}|{PointsPerEvent}|{_target}|{_bonus}|{_currentCount}|{_isComplete}";
    }

    private static string Escape(string s) => s.Replace("|","¦");

    public static ChecklistGoal FromSaveParts(string[] parts)
    {
        // parts (Checklist, name, description, points, target, bonus, current, completed)
        var name = parts[1].Replace("¦","|");
        var desc = parts[2].Replace("¦","|");
        int pts = int.Parse(parts[3]);
        int target = int.Parse(parts[4]);
        int bonus = int.Parse(parts[5]);
        int current = int.Parse(parts[6]);
        bool done = bool.Parse(parts[7]);

        var g = new ChecklistGoal(name, desc, pts, target, bonus);
        g._currentCount = current;
        g._isComplete = done;

        return g;
    }
}
