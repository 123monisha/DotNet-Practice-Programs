using System;

namespace Practical_Example
{
    public class Shape
    {
        public virtual void CalculateArea()
        {
            Console.WriteLine("This is the base class");
        }
    }

    public class Rectangle : Shape
    {
        int length, breadth;

        public Rectangle(int l, int b)
        {
            length = l;
            breadth = b;
        }

        public override void CalculateArea()
        {
            double area = length * breadth;
            Console.WriteLine($"Area of Rectangle: {area}");
        }
    }

    public class Circle : Shape
    {
        double pi = 3.14;
        double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override void CalculateArea()
        {
            double area = pi * radius * radius;
            Console.WriteLine($"Area of Circle: {area}");
        }
    }

    internal class InheritanceAndPolymorphism
    {
        static void Main(string[] args)
        {
            Shape shape;

            shape = new Rectangle(4, 8);
            shape.CalculateArea();

            shape = new Circle(6);
            shape.CalculateArea();

            Console.ReadLine(); // To keep console window open
        }
    }
}
