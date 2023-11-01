using System;

namespace _31_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "ana";
            p.age = 30;
            Console.WriteLine(p.toString());
            Person p1 = new Person() { name = "Maria", age = 18 };
            Console.WriteLine(p1.toString());

            Person p2 = new Person("Joana", 15);
            Console.WriteLine(p2.toString());
            Person p3 = new Person("Antonio");
            Console.WriteLine(p3.toString());

        }
    }
}