using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_10
{
     class Person
    {
        public string name;
        public int age;

        public Person()
        {
            //
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person(string name)
        {
            this.name = name;
        }

        public string toString()
        {
            return $"Nome: {name} Idade: {age}";
        }

    }
}
