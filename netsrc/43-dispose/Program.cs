using System;

namespace _43_dispose
{
    class Defer : IDisposable
    {
        public void Dispose() 
        {
            Console.WriteLine("bye!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using(new Defer()) 
            {
                Console.WriteLine("hi!");
            }
        }
    }
}
