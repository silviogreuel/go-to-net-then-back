using System;

namespace _3_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "initial";
            Console.WriteLine(a);

            //Csharp cant't do this
            //var b, c int = 1, 2
            //fmt.Println(b, c)

            //But can declare multiple variables then assign after
            int b, c;
            b = 1;
            c = 2;
            Console.WriteLine("{0} {1}", b, c);

            var d = true;
            Console.WriteLine(d);

            //Csharp does not allow to use unassigned variables
            //int e;
            //Console.WriteLine(e);

            //But to handle as golang handles, just assign default on declaration
            int e = default; 
            Console.WriteLine(e);

            //Csharp can't do this
            //https://golang.org/ref/spec#Short_variable_declarations
            //f := "apple"
            //fmt.Println(f)
        }
    }
}
