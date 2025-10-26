using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Example
{
    public class Shape
    {
        public virtual void CalculateArea()
        {
            Console.WriteLine("This method will calculate the area");
        }
    }
    public class Circle : Shape
    {
        double rr;
        public Circle(double r)
        {
            rr = r;
        }
        public override void CalculateArea()
        {
            double result = Math.PI * rr * rr;
            Console.WriteLine("Area of Circle is " + result);
        }

    }
    public class Rectangle : Shape
    {
        public double l;
        public double w;
        public Rectangle(double ll, double ww)
        {
            l = ll;
            w = ww;
        }
        public override void CalculateArea()
        {
            double res = l * w;
            Console.WriteLine("Area of Rectangle is" + res);
        }
    }
    internal class OOPs5
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            s.CalculateArea();
            Circle c = new Circle(9);
            c.CalculateArea();
            Rectangle r = new Rectangle(4, 7);
            r.CalculateArea();


        }
    }
}
