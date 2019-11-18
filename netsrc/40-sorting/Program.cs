using System;
using System.Collections.Generic;
using System.Linq;

namespace _40_sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var strs = new List<string>() {"c", "a", "b"};
            strs = strs.OrderBy(c => c).ToList();
            Console.WriteLine("strings: {0}", string.Join(", ", strs));

            var ints = new List<int>() {7, 2, 4};
            ints = ints.OrderBy(c => c).ToList();
            Console.WriteLine("ints: {0}", string.Join(", ", ints));

            //Generally available on testing assertions
            //s := sort.IntsAreSorted(ints)
            //fmt.Println("Sorted: ", s)
        }
    }
}
