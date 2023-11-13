using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_11
{
    class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public Moto() { }
        public Moto(string marca, int cilindradas) : base(marca)
        {

            Cilindradas = cilindradas;
        }

        public string ToStringVeiculo()
        {
            string stringPai = base.ToStringVeiculo();
            return $"{stringPai}{Cilindradas}";
           
        }
    }
}
