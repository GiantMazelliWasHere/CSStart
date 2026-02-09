using Generico;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinhaLista<int> numeros = new MinhaLista<int>();
            numeros.adicionarItem(10);
            numeros.adicionarItem(20);

            Console.WriteLine(numeros.pegarValor(0));
            Console.WriteLine(numeros.pegarValor(1));

            Utils utils = new Utils();

            int a = 5; 
            int b = 10;

            Console.WriteLine($"Antes da troca: a = {a}, b = {b}");

            utils.TrocarValores(ref a, ref b);

            Console.WriteLine($"Depois da troca: a = {a}, b = {b}");

            MinhaLista<string> nomes = new MinhaLista<string>();

            nomes.adicionarItem("Alice");
            nomes.adicionarItem("Bob");

            Console.WriteLine(nomes.pegarValor(1));


        }
    }
}