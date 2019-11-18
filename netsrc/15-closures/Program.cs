using System;

namespace _15_closures
{
    class Program
    {
        static Func<int> intSeq() 
        {
            int i = 0;
            return () => 
            {
                i++;
                return i;
            };
        }
        static void Main(string[] args)
        {
            var nextInt = intSeq();
            
            Console.WriteLine(nextInt());
            Console.WriteLine(nextInt());
            Console.WriteLine(nextInt());

            var nextInts = intSeq();
            Console.WriteLine(nextInts());
        }
    }
}
