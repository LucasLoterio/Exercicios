using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Dia_31_Mes_10
{
    internal class Produtos
    {
        private int codigo;
        private string descricao;
        private int estoque;
        private double ValorUnit;
        private double porcentagem;
            public int Codigo {
            get
            {
                return codigo;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("O numero precisa ser maior que 0");
                }
                else
                {
                    codigo = value;
                }
            }
        }
            public string Descricao { get
                {
                    return descricao;
                }
                set
                {
                    if (value.Length < 4)
                    {
                        Console.WriteLine("Descrição precisa ter no minimo 4 caracteres");
                    }
                    else
                    {
                        descricao = value;
                    }
                }
            }
            public int Estoque
        {
            get
            {
                return estoque;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("O numero precisa ser maior que 0");
                }
                else
                {
                    estoque = value;
                }
            }
        }
            public double valorUnit
        {
            get
            {
                return ValorUnit;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("O numero precisa ser maior que 0");
                }
                else
                {
                    ValorUnit = value;
                }
            }
        }
            public double Porcentagem
        {
            get
            {
                return porcentagem;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("O numero precisa ser maior que 0");
                }
                else
                {
                    porcentagem = value;
                }
            }
        }

            public double Desconto(double n)
            {
                var porcentagem = n / 100;
                var desconto = this.valorUnit * porcentagem;

                var aux = this.valorUnit;

                return aux -= desconto;
            }

            public double Acrescimo(double n)
            {
                var porcentagem = n / 100;
                var desconto = this.valorUnit * porcentagem;
                var aux = this.valorUnit;

                return aux += desconto;
            }

            public Produtos(int codigo, int estoque, double valorUnit, double porcentagem,string descricao)
        {
            Codigo = codigo;
            Estoque = estoque;
            ValorUnit = valorUnit;
            Porcentagem = porcentagem;
            Descricao = descricao;
            
        }

        public override string ToString()
            {
                return $"Código: {this.Codigo}\n" +
                    $"Descrição: {this.Descricao}\n" +
                    $"Estoque: {this.Estoque}\n" +
                    $"Valor unitário: {this.valorUnit}\n";
            }

        
    }
}
