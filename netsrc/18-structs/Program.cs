using System;

namespace _18_structs
{
    struct Person 
    {
        public string Name;
        public int Age; 

        public Person(string name)
        {
            Name = name;
            Age = 42;
        }
        public Person(string name, int age) 
        {
            Name = name;
            Age = age;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var alice = new Person("Alice");
            Console.WriteLine(alice);
            alice.Age = 20;
            Console.WriteLine(alice);
        }
    }
}
