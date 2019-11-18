using System;

namespace _13_multiple_return
{
    class Program
    {
        static (int, int) vals()
        {
            return (3, 7);
        }

        static void Main(string[] args)
        {
            var (a, b) = vals();
            Console.WriteLine(a);
            Console.WriteLine(b);

            var (_, c) = vals();
            Console.WriteLine(b);
        }
    }
}
