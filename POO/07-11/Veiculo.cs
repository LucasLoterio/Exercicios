using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_11
{
    class Veiculo
    {
        public string Marca { get; set; }
        public void ronco()
        {
            Console.WriteLine("Ronco do veiculo");
        }
        public Veiculo() { }
        public Veiculo( string marca)
        {
           
            Marca = marca;
        }

        public string ToStringVeiculo()
        {
            return $"{Marca} ";
        }
    }
}
