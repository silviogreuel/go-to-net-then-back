using System;
using System.Collections.Generic;

namespace _11_range
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[]{2, 3, 4};
            var sum = 0;
            foreach(var num in nums)
            {
                sum += num;
            }
            Console.WriteLine("sum: {0}", sum);

            var kvs = new Dictionary<string, string>
            {
                {"a", "apple"}, 
                {"b", "banana"},
            };

            foreach(var kv in kvs) 
            {
                Console.WriteLine("{0} -> {1}", kv.Key, kv.Value);
            }
        }
    }
}
