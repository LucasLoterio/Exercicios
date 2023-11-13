using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_11
{
    class MotoPasseio : Moto
    {
        public bool Bau;

        public MotoPasseio() { }
        public MotoPasseio(string marca, int cilindradas,bool bau) : base(marca,cilindradas)
        {

            Bau = bau;
        }

        public string ToStringVeiculo()
        {
            string stringPai = base.ToStringVeiculo();
            return $"{stringPai} bau = {Bau}";

        }
    }
}
