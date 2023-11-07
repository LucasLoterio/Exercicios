namespace _07_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            criarVeiculos();

            Console.ReadKey();
        }

        static void criaClientes()
        {
            Cliente cliente = new Cliente() { Id = 1, Nome = "Maria", Cpf = "123" };
            Console.WriteLine(cliente.ToString());
        }
        static void criarVeiculos()
        {
            /* Veiculo veiculo = new Veiculo() { Marca = "Jeep" };
           Console.WriteLine(veiculo.Marca);
           veiculo.ronco();*/
            Console.WriteLine("Escolha o veiculo \n (1)carro (2)moto de passeio (3)moto de competição ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Carro carro = new Carro() { Modelo = "Renegade" };
                    carro.Marca = "Jeep";
                    Console.WriteLine(carro.ToStringVeiculo());
                    break;
                case 2:
                    MotoPasseio moto = new MotoPasseio();
                    moto.Marca = "Honda";
                    moto.Cilindradas = 125;
                    moto.Bau = true;
                    Console.WriteLine(moto.ToStringVeiculo());
                    break;
                case 3:
                    MotoCompeticao motocompeticao = new MotoCompeticao();
                    motocompeticao.Marca = "Ducato";
                    motocompeticao.Cilindradas = 250;
                    motocompeticao.Equipe = "Ducato";
                    Console.WriteLine(motocompeticao.ToStringVeiculo());
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
           
        }
    }
}