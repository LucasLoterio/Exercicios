using static Dia_31_Mes_10.Exercicio1;

namespace Dia_31_Mes_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual exercício deseja acessar?");
            var opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Exercicio01();
                    break;

                case "2":
                    Exercicio02();
                    break;

                case "3":
                    Exercicio03();
                    break;

                case "4":
                    Exercicio04();
                    break;

            }
        }


        static void Exercicio01()
        {
            Console.WriteLine("Digite a placa do carro");
            var placa = Console.ReadLine();

            Console.WriteLine("Digite a marca do carro");
            var marca = Console.ReadLine();

            Console.WriteLine("Digite o modelo do carro");
            var modelo = Console.ReadLine();

            Console.WriteLine("Digite a cor do carro");
            var cor = Console.ReadLine();

            Carro car = new Carro(placa, marca, modelo, cor);
          

            
            Console.WriteLine(car);
        }

        static void Exercicio02()
        {
            Console.WriteLine("Escreva o 1º número:");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva o 2º número:");
            var y = Convert.ToInt32(Console.ReadLine());

            Calculadora calc = new();

            Console.WriteLine(calc.Somar(x, y));
            Console.WriteLine(calc.Subtrair(x, y));
            Console.WriteLine(calc.Multiplicar(x, y));
            Console.WriteLine(calc.Dividir(x, y));
        }

        static void Exercicio03()
        {
            Retangulo retangulo = new();

            Console.WriteLine("Digite a base do retângulo:");
            retangulo.Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a altura do retângulo");
            retangulo.Altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Área: {retangulo.Area()}");
            Console.WriteLine($"Perímetro: {retangulo.Perimetro()}");


        }

        static void Exercicio04()
        {
            Console.WriteLine("Digite o código do produto:");
            var Codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a descrição do produto:");
            var Descricao = Console.ReadLine();
            Console.WriteLine("Digite o estoque do produto:");
            var Estoque = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto:");
            var valorUnit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite 1 para aplicar DESCONTO ou 2 para ACRÉSCIMO");
            var opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem:");
            var Porcentagem = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Produtos produto = new(Codigo, Estoque, valorUnit, Porcentagem, Descricao);

            if (opcao == 1)
            {
                Console.WriteLine(produto);
                Console.WriteLine($"Valor após desconto: {produto.Desconto(produto.Porcentagem)}");
            }
            else
            {
                Console.WriteLine(produto);
                Console.WriteLine($"Valor após acréscimo: {produto.Acrescimo(produto.Porcentagem)}");

            }


        }
    }
}   