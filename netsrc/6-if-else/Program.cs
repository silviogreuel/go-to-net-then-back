using System;

namespace _6_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            if (7%2 == 0) {
                Console.WriteLine("7 is even");
            } else {
                Console.WriteLine("7 is odd");
            }

            if (8%4 == 0) {
                Console.WriteLine("8 is divisible by 4");
            }

            var num = 9;
            if (num < 0) {
                Console.WriteLine("{0} is negative", num);
            } else if (num < 10) {
                Console.WriteLine("{0} has 1 digit", num);
            } else {
                Console.WriteLine("{0} has multiple digits", num);
            }
        }
    }
}
