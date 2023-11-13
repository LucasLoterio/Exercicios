using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_11
{
    class Cliente : Pessoa
    {
        public string Cpf { get; set; }

        public Cliente() 
        { }
        public Cliente(int id,string nome, string cpf) : base(id, nome)
        {
          
            Cpf = cpf;
        }

        public string ToString()
        {
            
            string stringPai = base.ToString();
            return $"{stringPai}{Cpf}";
        }
    }
}
