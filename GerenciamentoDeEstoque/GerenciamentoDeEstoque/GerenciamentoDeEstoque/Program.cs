using GerenciamentoDeEstoque;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Teste com os produtos
            var estoqueProdutos = new Estoque<Produto>();

            estoqueProdutos.Add(new Produto { Id = 1, Nome = "Notebook", Preco = 4500 });
            estoqueProdutos.Add(new Produto { Id = 2, Nome = "Mouse Gamer", Preco = 150 });

            estoqueProdutos.ListAll();

            // Teste com os Usuarios 
            var estoqueUsuarios = new Estoque<Usuario>();

            estoqueUsuarios.Add(new Usuario { Id = 1, Nome = "Edson", Email = "edson@email.com" });
            estoqueUsuarios.Add(new Usuario { Id = 2, Nome = "Maria", Email = "maria@email.com" });

            estoqueUsuarios.ListAll();

            // Teste com os Pedidos
            var estoquePedidos = new Estoque<Pedido>();

            estoquePedidos.Add(new Pedido { Id = 1, Descricao = "Pedido Notebook", ValorTotal = 4500 });
            estoquePedidos.Add(new Pedido { Id = 2, Descricao = "Pedido Mouse", ValorTotal = 150 });

            estoquePedidos.ListAll();

            Console.WriteLine("\nSistema finalizado. Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}