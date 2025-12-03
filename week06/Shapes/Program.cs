using System;
using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of base type Shape
            List<Shape> shapes = new List<Shape>();

            // Add different derived shape objects
            shapes.Add(new Square("Red", 5.0));          // side = 5
            shapes.Add(new Rectangle("Blue", 4.0, 2.5)); // width = 4, height = 2.5
            shapes.Add(new Circle("Green", 3.0));        // radius = 3

            Console.WriteLine("Shapes and Areas:");

            // Polymorphism same call GetArea() behaves differently for each object
            foreach (Shape s in shapes)
            {
                string color = s.GetColor();
                double area = s.GetArea(); 
                Console.WriteLine($"{color} shape has area: {area:F2}");
            }

            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }

