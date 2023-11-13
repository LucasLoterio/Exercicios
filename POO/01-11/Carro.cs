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


        public static void adicionar(List<Carro> carros)
        {
            Console.Clear();
            try
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
                listar();
            }
            catch
            {

            }
        }
        public static void excluir(List<Carro> carros)
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

        public static void alterar(List<Carro> carros)
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
                        Console.WriteLine(carros[i]);
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

        static void listar(List<Carro> carros)
        {
            foreach (Carro carro in carros)
            {
                Console.WriteLine(carro.ToString());
            }
        }
    }
}
