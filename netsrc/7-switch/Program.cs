using System;

namespace _7_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 2;
            Console.WriteLine("Write {0} {1}", i, " as ");
            switch (i) 
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
            }

            switch (DateTime.Now.DayOfWeek) 
            {
                case DayOfWeek.Saturday: 
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's the weekend");
                    break;
                default:
                    Console.WriteLine("It's a weekday");
                    break;
            }

            var t = DateTime.Now;
            switch (t.Hour) 
            {
                case int h when h < 12:
                    Console.WriteLine("It's before noon");
                    break;
                default:
                    Console.WriteLine("It's after noon");
                    break;
            }

            whatAmI(true);
            whatAmI(1);
            whatAmI("hey");
        }

        static void whatAmI<T>(T i)
        {
            switch (i) 
            {
                case bool b:
                    Console.WriteLine("I'm a bool");
                    break;
                case int b:
                    Console.WriteLine("I'm an int");
                    break;
                default:
                    Console.WriteLine("Don't know type {0}", typeof(T));
                    break;
            }
        }
    }
}
