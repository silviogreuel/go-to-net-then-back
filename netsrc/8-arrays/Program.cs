using System;

namespace _8_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("emp:", a);

            a[4] = 1000;
            Console.WriteLine("set: {0}", a);
            Console.WriteLine("get: {0}", a[4]);

            Console.WriteLine("len: {0}", a.Length);

            int[] b = new []{1, 2, 3, 4, 5};
            Console.WriteLine("dcl: {0}", b);

            int[,] twoD = new int[2, 3];
            for (var i = 0; i < 2; i++) {
                for (var j = 0; j < 3; j++) {
                    twoD[i, j] = i + j;
                }
            }
            Console.WriteLine(twoD);
        }
    }
}
