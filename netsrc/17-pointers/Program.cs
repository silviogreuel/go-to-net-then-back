using System;

namespace _17_pointers
{
    class Program
    {
        static void zeroval(int ival)
        {
            ival = 0;
        }

        unsafe static void zeroptr(int* iptr)
        {
            *iptr = 0;
        }
        unsafe static void Main(string[] args)
        {
            var i = 1;
            Console.WriteLine("initial: {0}", i);

            zeroval(i);
            Console.WriteLine("zeroval: {0}", i);

            zeroptr(&i);
            Console.WriteLine("zeroptr: {0}", i);

            int* ptr = &i;
            Console.WriteLine("pointer: {0}", ((IntPtr)ptr).ToString("x"));
        }
    }
}
