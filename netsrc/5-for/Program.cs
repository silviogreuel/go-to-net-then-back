using System;

namespace _5_for
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            while (i <= 3) 
            {
                Console.WriteLine(i);
                i = i + 1;
            }

            for (int j = 7; j <= 9; j++)
            {
                Console.WriteLine(j);
            }

            for (;;) 
            {
                Console.WriteLine("loop");
                break;
            } 

            for (var n = 0; n <= 5; n++)
            {
                if (n%2 == 0) 
                {
                    continue;
                }
                Console.WriteLine(n);
            }
        }
    }
}
