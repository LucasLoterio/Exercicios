using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia_31_Mes_10
{
    internal class Calculadora
    {
        public int Somar(int x, int y)
        {
            return x + y;
        }

        public int Subtrair(int x, int y)
        {
            return x - y;
        }

        public int Dividir(int x, int y)
        {
            return x / y;
        }

        public int Multiplicar(in int x, in int y)
        {
            return x * y;
        }
    }
}
