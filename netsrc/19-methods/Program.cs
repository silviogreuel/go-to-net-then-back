using System;

namespace _19_methods
{
    struct Rect 
    {
        public int Width;
        public int Height;

        public Rect(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Area() 
        {
            return Width * Height;
        }

        public int Perim()
        {
            return 2*Width + 2*Height;
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Rect(10, 5);
            Console.WriteLine("area: {0}", r.Area());
            Console.WriteLine("perim: {0}", r.Perim());
        }
    }
}
