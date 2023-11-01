using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_11
{
   
        internal class Carro
        {
            private string placa;
            private string marca;
            private string modelo;
            private string cor;




            public string Placa
            {
                get
                {
                    return placa;
                }
                set
                {
                    if (value.Length < 7)
                    {
                        Console.WriteLine("Placa invalida");
                        throw new FormatException();
                    }
                    else
                    {
                        placa = value;
                    }
                }
            }
            public string Marca
            {
                get
                {
                    return marca;
                }
                set
                {
                    if (value.Length < 3)
                    {
                        Console.WriteLine("Marca invalida");
                        throw new FormatException();
                    }
                    else
                    {
                        marca = value;
                    }
                }
            }
            public string Modelo
            {
                get
                {
                    return modelo;
                }
                set
                {
                    if (value.Length < 2)
                    {
                        Console.WriteLine("Marca invalida");
                        throw new FormatException();
                    }
                    else
                    {
                        modelo = value;
                    }
                }
            }
            public string Cor
            {
                get
                {
                    return cor;
                }
                set
                {
                    if (value.Length < 4)
                    {
                        Console.WriteLine("Cor invalida");
                        throw new FormatException();
                    }
                    else
                    {
                        cor = value;
                    }
                }
            }

            public Carro()
            {

            }
            public Carro(string placa, string marca, string modelo, string cor)
            {
                Placa = placa;
                Marca = marca;
                Modelo = modelo;
                Cor = cor;
            }

            public override string ToString()
            {
                return $"Placa: {this.Placa}\n" +
                    $"Marca: {this.Marca}\n" +
                    $"Modelo: {this.Modelo}\n" +
                    $"Cor: {this.Cor}";
            }

        }
    
}
