using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeEstoque
{
    // Classe genérica para gerenciar o estoque de produtos, pedidos e usuários
    public class Estoque<T> where T : IdIdentificavel
    {
        private List<T> itens = new List<T>();

        // Adiciona os itens ao estoque
        public void Add(T item)
        {
            itens.Add(item);
            Console.WriteLine("Item adicionado com sucesso!");
        }

        // Remover por item por ID
        public void Remove(int id)
        {
            var item = itens.FirstOrDefault(x => x.Id == id);

            if (item != null)
            {
                itens.Remove(item);
                Console.WriteLine("Item removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Item não encontrado!");
            }
        }

        // Buscar por Id
        public T? SearchId(int id)
        {
            return itens.FirstOrDefault(x => x.Id == id);
        }

        // Listar todos os itens do estoque
        public void ListAll()
        {
            Console.WriteLine("\n--- LISTA DE ITENS ---");

            foreach (var item in itens)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------\n");
        }
    }
}
