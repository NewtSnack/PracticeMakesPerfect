using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    abstract class Shape
    {
        public string Name { get; set; }

        public virtual void getInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }
        public abstract double Area();
    }
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }
        public override void getInfo()
        {
            base.getInfo();
            Console.WriteLine($"It has a Radius of: {Radius}");
        }
    }
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Name = "Rectangle"; 
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }
        public override void getInfo()
        {
            base.getInfo();
            Console.WriteLine($"It has a Length of {Length} and a Width of {Width}");
        }
    }
}
