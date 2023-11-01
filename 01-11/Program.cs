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
                        adicionar();
                        break;
                    case 2:
                        alterar();
                        break;
                    case 3:
                        excluir();
                        break;
                    case 4:
                        listar();
                        break;
                }
            }
           


            Console.ReadKey();
        }
        static void adicionar()
        {
            Console.Clear(); try
            {


                Console.WriteLine("Digite a placa do carro");
                var placa = Console.ReadLine();

                Console.WriteLine("Digite a marca do carro");
                var marca = Console.ReadLine();

                Console.WriteLine("Digite o modelo do carro");
                var modelo = Console.ReadLine();

                Console.WriteLine("Digite a cor do carro");
                var cor = Console.ReadLine();

                for (int index = 0; index < carros.Count; index++)
                {
                    if (placa == carros[index].Placa)
                    {
                        Console.WriteLine("Placa inalida");
                        throw new FormatException();
                    }
                }

                Carro car = new Carro(placa, marca, modelo, cor);

                carros.Add(car);
            }
            catch
            {
                
            }

            
            Console.Clear();

        }

        static void alterar()
        {
            listar();
            Console.WriteLine("Digite a placa do carro q dejesa alterar");
            string aux = Console.ReadLine();
            Console.Clear();
            try
            {
                for (int i = 0; i < carros.Count; i++)
                {
                    if (carros[i].Placa.Equals(aux))
                    {
                        Console.WriteLine($"" +
                        $"**************************************** \n\n" +
                        $"   Digite 1 para alterar a placa\n" +
                        $"   Digite 2 para alterar a marca\n" +
                        $"   Digite 3 para alterar a modelo \n" +
                        $"   Digite 4 para alterar a cor \n\n" +
                        $"****************************************");
                    }
                    int opcao = Convert.ToInt32(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Digite nova placa");
                            string np = Console.ReadLine();
                            carros[i].Placa = np;
                            break;
                        case 2:
                            Console.WriteLine("Digite nova marca");
                            string nm = Console.ReadLine();
                            carros[i].Marca = nm;
                            break;
                        case 3:
                            Console.WriteLine("Digite o novo modelo");
                            string nmo = Console.ReadLine();
                            carros[i].Modelo = nmo;
                            break;
                        case 4:
                            Console.WriteLine("Digite nova cor");
                            string cr = Console.ReadLine();
                            carros[i].Cor = cr;
                            break;
                    }
                }
            }
            catch
            {

            }
           
           
        }

        static void excluir()
        {
            listar();
            Console.WriteLine("Digite a placa do carro q dejesa excluir");
            string aux = Console.ReadLine();
            for (int i = 0; i < carros.Count; i++)
            {
                if (carros[i].Placa.Equals(aux))
                {
                    carros.RemoveAt(i);
                }
            }
            Console.Clear();
        }
        static void listar()
        {
            foreach (Carro carro in carros)
            {
                Console.WriteLine(carro.ToString());
            }
        }



    }
}