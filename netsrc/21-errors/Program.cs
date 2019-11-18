using System;

namespace _21_errors
{
    class Program
    {
        static int f1(int arg)
        {
            if (arg == 42) 
            {
                throw new Exception("can't work with 42");
            }
            return arg + 3;
        }
        
        class ArgError : Exception
        {
            public int Arg;
            public string Prob;

            public ArgError(int arg, string prob) : base(prob)
            {
                Arg = arg;
                Prob = prob;
            }
        }

        static int f2(int arg)
        {
            if (arg == 42)
            {
                throw new ArgError(arg, "can't work with it");
            }

            return arg + 3;
        }

        static void Main(string[] args)
        {
            try 
            {
                f1(42);
            } 
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            try 
            {

                f2(42);
            } 
            catch(ArgError e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
