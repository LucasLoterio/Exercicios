using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_11
{
    internal class MotoCompeticao : Moto
    {
        public string Equipe;

        public MotoCompeticao() { }
        public MotoCompeticao(string marca, int cilindradas, string equipe) : base(marca, cilindradas)
        {

            Equipe = equipe;
        }

        public string ToStringVeiculo()
        {
            string stringPai = base.ToStringVeiculo();
            return $"{stringPai} {Equipe}";

        }
    }
}
