using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dia_31_Mes_10
{

        internal class Retangulo
        {
                    private int bases;
                    private int altura;
            
                    public int Base
                    {
                    get
                    {
                        return bases;
                    }
                    set
                    {
                        if (value < 0)
                        {
                            Console.WriteLine("O numero precisa ser maior que 0");
                        }
                        else
                        {
                            bases = value;
                        }
                    }
                    }
                    public int Altura
                    {
                    get
                    {
                        return altura;
                    }
                    set
                    {
                        if (value < 0)
                        {
                            Console.WriteLine("O numero precisa ser maior que 0");
                        }
                        else
                        {
                            altura = value;
                        }
                    }
                    }

                    public int Area()
                    {
                        return this.Base * this.Altura;
                    }

                    public int Perimetro()
                    {
                        return (2 * this.Base) + (2 * this.Altura);
                    }

                    public Retangulo()
                    {

                    }
                    public Retangulo(int bases, int altura)
                    {
                        Base = bases;
                        Altura = altura;
                    }

       

        }
    
}
