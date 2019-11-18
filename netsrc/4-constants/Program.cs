using System;

namespace _4_constants
{
    class Program
    {
        const string s1 = "constant 1";
        //Csharp does not allow to use contextual keyword 'var' here
        //const var s2 = "constant 2";

        static void Main(string[] args)
        {
            Console.WriteLine(s1);
            //Console.WriteLine(s2);

            //Csharp does not allow to use implicitly-typed variables as constants
            //const var n = 1;
            const double n = 500000000;

            const double d = 3e20 / n;
            Console.WriteLine(d);

            Console.WriteLine(Math.Sin(d));
        }
    }
}
