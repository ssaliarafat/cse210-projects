// The Base class
using System;
    public class Shape
    {
        private string _color;

        public Shape(string color)
        {
            _color = color;
        }

        // Getter and setter for color (encapsulation)
        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        // Virtual method for area. Derived classes will override this.
        public virtual double GetArea()
        {
            return 0.0; // default - base doesn't know shape details
        }
    }
