using System;

namespace _16_recursion
{
    class Program
    {
        static int fact(int n) 
        {
            if (n == 0) {
                return 1;
            }
            return n * fact(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(fact(7));
        }
    }
}
