using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int r;

            Console.WriteLine("Insira o valor 1:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor 2:");
            n2 = int.Parse(Console.ReadLine());

            r = n1 + n2;

            if (r == 0)
            {
                Console.WriteLine("A soma de " + n1 + " e " + n2 + " é zero.");
            }
            if (r > 0)
            {
                Console.WriteLine("A soma de " + n1 + " e " + n2 + " é " + r + " então é positiva.");
            }
            if (r < 0)
            {
                Console.WriteLine("A soma de " + n1 + " e " + n2 + " é " + r + " então é negativa.");
            }
        }
    }
}