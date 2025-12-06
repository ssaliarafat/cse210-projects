using System;

    // Base class, all the goals inherit from this
    public abstract class Goal
    {
        private string _shortName;
        private int _points;
        private string _description;

        protected Goal(string name, string description, int points) // constructor
        {
            _shortName = name;
            _description = description;
            _points = points;
        }

        // The getters
        public string Name => _shortName;
        public string Description => _description;
        public int PointsPerEvent => _points;


        // Polymorphism behavior, These methods will be overridden in children classes
        public abstract int RecordEvent();

        public abstract bool IsComplete();

        // Human readable status for listing
        public abstract string GetStringRepresentation();

        public abstract string GetDetailsString();

        // Provide a line for saving to disk
        public abstract string ToSaveString();

    }
