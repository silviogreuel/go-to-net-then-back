using System;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Threading;

namespace _23_channels
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<string> messages = new BlockingCollection<string>(); 
            Task.Factory.StartNew(() => 
            {
                messages.Add("ping");
                messages.CompleteAdding();
            });
            foreach (string item in messages.GetConsumingEnumerable())
            {
                Console.WriteLine(item);
            }
        }
    }
}
