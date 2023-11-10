using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Agrecação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio2();
            Console.ReadKey();
        }

        static void Exercicio1()
        {
            SortedList<string, Pessoa> files = new SortedList<string, Pessoa>();
            Pessoa gabi = new Pessoa(18, "Blumenau", 18772);

            files.Add("Gabriel",gabi);
            
;
           

            Object[] valores = files.Values.ToArray();
            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            IList<string> chaves = files.Keys;
            foreach (string k in chaves)
            {
                Console.WriteLine($"Key:{k}  {files[k].ToString()}");
            }
           
            

        }

   

        static void Exercico3()
        {
            SortedList<Categoria, Pessoa> files = new SortedList<Categoria, Pessoa>();
            Produto gabi = new Produto(1, "Fruta", 18,77);
            Categoria jogo = new Categoria(1, "mmorpg");
            jogo.ToString();
                
            files.Add(jogo , gabi);

            


            Object[] valores = files.Values.ToArray();
            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            IList<string> chaves = files.Keys;
            foreach (string k in chaves)
            {
                Console.WriteLine($"Key:{k}  {files[k].ToString()}");
            }

        }
        static void Exercicio2()
        {
            List<string> produtos = new List<string>();
            bool opcao = false;
            while (!opcao)
            {
                Console.WriteLine("Digite o produto selecionado");
                string aux = Console.ReadLine();
                if (
                    produtos.Contains(aux) )
                {
                    Console.WriteLine($"O produto {aux} ja esta na lista");
                }
                else
                {
                    produtos.Add(aux);
                }
                Console.WriteLine("Dejesa adicionar outro? \n (sim) (Qualquer outra tecla)");
                string confirma = Console.ReadLine().ToLower();
                if(confirma == "sim")
                {
                    Console.WriteLine("Lista:\n");
                    for(int i = 0; i < produtos.Count;i++)
                    {
                        Console.WriteLine($"{produtos[i]}");
                    }
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Lista:\n");
                    for (int i = 0; i < produtos.Count; i++)
                    {
                        Console.WriteLine($"{produtos[i]}");
                    }
                    opcao = true;
                    break;
                }

            }
        }

        
    }
}