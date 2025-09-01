using System;

namespace MyApp
{
    internal class Program
    {
        const String mensagem = "Eu amo góticas!";
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
        static void forFuction(String mensagem)
        {
            for (int i = 0; i < 1000; i++)
            {
                // for -> parar, i de index
                Console.WriteLine(mensagem);
                Console.WriteLine($"index:{i}");
            }
        }

        static void whileFunction(String mensagem, int index)
        {
            int i = 0;
            while (i < index)
            {
                // while -> enquanto
                Console.WriteLine(mensagem);
                Console.WriteLine($"index:{i}");
                i++;
            }
        }
    }
}