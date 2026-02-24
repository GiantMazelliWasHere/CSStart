using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contatos = new Dictionary<string, string>();

            contatos.Add("Eduardo", "99999-9999");
            contatos.Add("Maria", "88888-8888");
            contatos.Add("João", "77777-7777");

            Console.WriteLine("Digite o nome do contato que deseja obter o telefone:");
            string nome = Console.ReadLine();
            string telefone;

            if (contatos.ContainsKey(nome))
            {
                if (contatos.TryGetValue(nome, out telefone))
                {
                    Console.WriteLine($"Telefone de {nome}: {telefone}");
                }
                else
                {
                    Console.WriteLine($"Contato {nome} encontrado, mas não foi possível obter o telefone.");
                }
            }
            else
            {
                Console.WriteLine($"Contato {nome} não encontrado.");
            }
        }
    }
}