using System;
using System.IO;

namespace _42_panic
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new Exception("a problem");

            File.Create("/tmp/file");
        }
    }
}
