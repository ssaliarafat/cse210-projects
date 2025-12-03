// Rectangle class
using System;
    public class Rectangle : Shape
    {
        private double _width;
        private double _length;

        public Rectangle(string color, double width, double length) : base(color)
        {
            _width = width;
            _length = length;
        }

        public double GetWidth() => _width;
        public double GetLength() => _length;

        public override double GetArea()
        {
            return _width * _length;
        }
    }
