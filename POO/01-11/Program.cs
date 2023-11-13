using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace _01_11
{
    class Program
    {

        public static List<Carro> carros = new List<Carro>();
        static void Main(string[] args)
        {
            bool condicao = false;
            while (!condicao)
            {
                Console.WriteLine("Você dejesa utilizar o programa? \n" +
                    "(sim)   (nao)");

                string resposta = Console.ReadLine().ToLower();
                Console.Clear();

                if (resposta == "nao")
                {
                    break;
                }
                Console.WriteLine($"" +
                    $"**************************************** \n\n" +
                    $"   Digite 1 se deseja adicionar \n" +
                    $"   Digite 2 se deseja alterar \n" +
                    $"   Digite 3 se deseja excluir \n" +
                    $"   Digite 4 se dejesa listar \n\n" +
                    $"****************************************");

                var opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Carro.adicionar(carros);
                        break;
                    case 2:
                        Carro.alterar(carros);
                        break;
                    case 3:
                        Carro.excluir(carros);
                        break;
                    case 4:
                        Carro.listar(carros);
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}