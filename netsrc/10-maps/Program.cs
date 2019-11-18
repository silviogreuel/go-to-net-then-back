using System;
using System.Collections.Generic;

namespace _10_maps
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new Dictionary<string, int>();
            m["k1"] = 7;
            m["k2"] = 13;

            Console.WriteLine("map: {0}", m);

            var v1 = m["k1"];
            Console.WriteLine("v1: {0}", v1);

            Console.WriteLine("len: {0}", m.Count);

            m.Remove("k2");
            Console.WriteLine("map: {0}", m);

            try 
            {
                var prs = m["k2"];
                Console.WriteLine("prs: {0}", prs);
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var n = new Dictionary<string, int> 
            {
                {"foo", 1}, 
                {"bar", 2},
            };
            Console.WriteLine("map: {0}", n);
        }
    }
}
