using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrecação
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public string ToString()
        {
            return $"{Id} {Descricao} {Preco}";
        }
    }
}
