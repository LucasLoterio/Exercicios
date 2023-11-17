namespace Files
{
    internal class Program
    {
        static string path = @"C:\Users\lucas.loterio\Documents\Entra21\Exercicios\POO\teste.txt";
        static void Main(string[] args)
        {

            bool resposta = false;

            while (!resposta)
            {
                criarArquivo();
                Console.WriteLine("*************************************** \n\n" +
                                 "Digite 1 para criar um contato \n" +
                                 "Digite 2 para ver os contatos listados \n\n" +
                                 "***************************************");
                int opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        criarContato();
                        break;
                    case 2:
                        lerArquivo();
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
                Console.WriteLine("Deseja continuar utilizando nosso programa?????? \n" +
                              "[Sim]          [Não]   ");
                string aux = Console.ReadLine().ToLower();
                if (aux == "sim")
                {
                    resposta = false;
                }
                else
                {
                    resposta = true;
                }
            }
            Console.ReadKey();
        }
        static void criarArquivo()
        {
            if (!File.Exists(path))
            {
                // File.CreateText(path);
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Contatos:");

                }
            }
        }
        static void lerArquivo()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        static void criarContato()
        {

            Console.WriteLine("Escreva o nome do contato");
            string contato = Console.ReadLine();
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(contato);
            }
            Console.Clear();
        }
    }

}