using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> produtos = new List<string>();

            produtos.Add("Notebook");
            produtos.Add("Mouse");
            produtos.Add("Teclado");
            produtos.Add("Monitor");
            produtos.Add("Mousepad");

            foreach (string produto in produtos)
            {
                Console.WriteLine(produto);
                
            }
            Console.WriteLine("-------------");

            produtos.Remove("Monitor");

            foreach (string produto in produtos)
            {
                Console.WriteLine(produto);
            }
        }
    }
}