using System;

namespace _14_variadic_functions
{
    class Program
    {
        static void sum(params int[] nums)
        {
            Console.WriteLine(nums);
            var total = 0;
            foreach(var num in nums) 
            {
                total += num;
            }
            Console.WriteLine(total);
        }
        static void Main(string[] args)
        {
            sum(1, 2);
            sum(1, 2, 3);

            var nums = new int[] {1, 2, 3, 4};
            sum(nums);
        }
    }
}
