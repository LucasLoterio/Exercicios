namespace Exercicio_3
{
    class Program
    {
        
       
        static void Main()
        {
            Dictionary<string, List<Produto>> categorias = new Dictionary<string, List<Produto>>();

            AdicionarProduto(categorias, "Eletrônicos", new Produto("Celular", 999.99));
            AdicionarProduto(categorias, "Eletrônicos", new Produto("Notebook", 1999.99));
            AdicionarProduto(categorias, "Roupas", new Produto("Camiseta", 29.99));
            AdicionarProduto(categorias, "Roupas", new Produto("Tennis", 49.99));
            AdicionarProduto(categorias, "Alimentos", new Produto("Arroz", 5.99));
            AdicionarProduto(categorias, "Alimentos", new Produto("Maçã", 1.99));

            ExibirProdutosPorCategoria(categorias);

            Console.ReadLine();
        }

        static void AdicionarProduto(Dictionary<string, List<Produto>> categorias, string categoria, Produto produto)
        {
            if (!categorias.ContainsKey(categoria))
            {
                categorias[categoria] = new List<Produto>();
            }

            categorias[categoria].Add(produto);
        }

        static void ExibirProdutosPorCategoria(Dictionary<string, List<Produto>> categorias)
        {
            foreach (var categoria in categorias)
            {
                Console.WriteLine($"Categoria: {categoria.Key}");

                foreach (var produto in categoria.Value)
                {
                    Console.WriteLine($"  {produto}");
                }

                Console.WriteLine();
            }
        }
    }
}