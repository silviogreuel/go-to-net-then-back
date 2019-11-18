using System;
using System.Collections.Generic;
using System.Linq;

namespace _9_slices
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new List<string>(3);
            Console.WriteLine("emp: {0}", s);

            s.Insert(0, "a");
            s.Insert(1, "b");
            s.Insert(2, "c");
            Console.WriteLine("set: {0}", s);
            Console.WriteLine("get: {0}", s[2]);

            Console.WriteLine("len: {0}", s.Count);

            s.Add("d");
            s.AddRange(new List<string>{"e", "f"});
            Console.WriteLine("apd: {0}", s);

            var c = new List<string>(s.Count);
            foreach(var e in s) 
            {
                c.Add(e);
            }
            Console.WriteLine("cpy: {0}", c);

            var l = s.Skip(2).Take(5);
            Console.WriteLine("sl1: {0}", l);

            l = s.Take(5);
            Console.WriteLine("sl2: {0}", l);

            l = s.Skip(2);
            Console.WriteLine("sl3: {0}", l);

            string[] t = new string[]{"g", "h", "i"};
            Console.WriteLine("dcl: {0}", t);

            var twoD  = new List<List<int>>();
            for (var i = 0; i < 3; i++) {
                var innerLen = i + 1;
                twoD.Insert(i, new List<int>());
                for (var j = 0; j < innerLen; j++) {
                    twoD.ElementAt(i).Insert(j, i + j);
                }
            }
            Console.WriteLine("2d: {0}", twoD);
        }
    }
}
