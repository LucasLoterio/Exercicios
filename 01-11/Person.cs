using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_11
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string ToString()
        {
            return $"Id:{Id} Nome:{Name}";
        }
    }
}
