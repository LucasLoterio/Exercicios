using System;

namespace _01_11
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> persons = new List<Person>();
            persons.Add(new Person() { Id = 1, Name = "Maria" });
            persons.Add(new Person() { Id = 2, Name = "Ana" });
            persons.Add(new Person() { Id = 3, Name = "Pedro" });

            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }

            /* List<string> list = new List<string>();
             list.Add("Ana");
            Console.WriteLine(list.Count);
            list.Add("Maria");
            list.Add("Pedro");
            Console.WriteLine(list.Count);

             Console.WriteLine("Imprimindo usando forma não indexada");
             foreach(string item in list)
             {
                Console.WriteLine(item);
             }

             int posSearch = list.IndexOf("Maria");
             Console.WriteLine(posSearch);
             list[posSearch] = "Maria das Dores";
             list.Remove("Pedro");

             Console.WriteLine("Imprimindo usando forma indexada");
             for(int i = 0; i < list.Count; i++)
             {
                 Console.WriteLine(list[i]);
             }*/
            Console.ReadKey();
        }
    }
}