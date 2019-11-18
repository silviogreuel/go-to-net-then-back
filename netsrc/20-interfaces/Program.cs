using System;

namespace _20_interfaces
{
    interface IGeometry 
    {
        double Area();
        double Perim();
    }

    struct Rect : IGeometry
    {
        public double Width;
        public double Height;

        public Rect(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area() 
        {
            return Width * Height;
        }

        public double Perim()
        {
            return 2*Width + 2*Height;
        }
    }

    struct Circle : IGeometry
    {
        public double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area() 
        {
            return Math.PI * Radius * Radius;
        }

        public double Perim()
        {
            return 2 * Math.PI * Radius;
        }
    }

    class Program
    {
        static void Measure(IGeometry geo)
        {
            Console.WriteLine(geo);
            Console.WriteLine(geo.Area());
            Console.WriteLine(geo.Perim());
        }
        static void Main(string[] args)
        {
            var r = new Rect(3, 4);
            var c = new Circle(5);

            Measure(r);
            Measure(c);
        }
    }
}
