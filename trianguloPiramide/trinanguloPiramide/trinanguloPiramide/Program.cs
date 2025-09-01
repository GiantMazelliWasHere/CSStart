using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variavel para controlar o numero de linhas, ou altura de triangulo
            int linhas = 10;

            // Variavel para controlar em qual linha estamos
            int i = 0;

            // Loop para desenhar o triangulo
            while (i < linhas)
            {
                
                // Variavel que controla os espaços em branco
                int espacos = linhas - i - 1;

                // Contador para os espaços em branco
                int j = 0;

                // Loop para desenhar os espaços em branco
                while (j < espacos)
                {
                    Console.Write(" ");
                    j++;
                }

                // Contador para os asteriscos
                int k = 0;

                // Loop para desenhar os asteriscos
                while (k < 2 * i + 1)
                {
                    Console.Write("*");
                    k++;
                }

                // Pula para a proxima linha
                Console.WriteLine();

                // Incrementa o contador de linhas
                i++;
            }
        }
    }
}