using System;

namespace _12_functions
{
    class Program
    {
        static int plus(int a, int b) 
        {
            return a + b;
        }

        //Csharp can't do this
        //static int plusPlus(int a, b, c) 
        //{
        //    return a + b + c;
        //}
        static void Main(string[] args)
        {
            var res = plus(1, 2);
            Console.WriteLine("1+2={0}", res);
        }
    }
}
