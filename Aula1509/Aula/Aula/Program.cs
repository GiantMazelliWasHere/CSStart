using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] listaNumeros = { 5, 6, 4, 13 };

            Console.WriteLine("Digite 4 números separados por espaço:");
            string[] entrada = Console.ReadLine().Split(' ');

            
            if (entrada.Length != listaNumeros.Length)
            {
                Console.WriteLine("Você deve digitar exatamente 4 números!");
                return;
            }

            
            int[] numerosDigitados = new int[4];
            bool entradaValida = true;

            
            for (int i = 0; i < entrada.Length; i++)
            {
                if (int.TryParse(entrada[i], out int numero))
                {
                    numerosDigitados[i] = numero;
                }
                else
                {
                    Console.WriteLine($"A entrada '{entrada[i]}' não é um número válido.");
                    entradaValida = false;
                    break;
                }
            }

            if (!entradaValida)
            {
                return;
            }

            
            bool senhaCorreta = true;
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                if (numerosDigitados[i] != listaNumeros[i])
                {
                    senhaCorreta = false;
                    break;
                }
            }

            
            if (senhaCorreta)
            {
                Console.WriteLine("Senha correta!");
                Console.WriteLine("Entrando.....");
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                Console.WriteLine("Começe de Novo!");
            }
        }
    }
}