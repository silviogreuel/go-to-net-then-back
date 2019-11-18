using System;
using System.Threading;
using System.Threading.Tasks;

namespace _22_tasks
{
    class Program
    {
        static void work(string from)
        {
            for (int i = 0; i <= 3 ; i++)
            {
                Console.WriteLine("{0}:{1}", i, from);
            }
        }
        static void Main(string[] args)
        {
            work("direct");

            Task.Run(() => {work("task");});

            Task.Run(() => 
            {
                Console.WriteLine("going");
            });

            Thread.Sleep(1000);

            Console.WriteLine("done!");
        }
    }
}
