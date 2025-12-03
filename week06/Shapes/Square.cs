// Square class
using System;
    public class Square : Shape
    {
        private double _side;

        public Square(string color, double side) : base(color)
        {
            _side = side;
        }

        public double GetSide()
        {
            return _side;
        }

        // Override the base GetArea method
        public override double GetArea()
        {
            return _side * _side;
        }
    }
