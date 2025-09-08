// Projeto de Avaliação (Revisado) - Variante 4: Mini Calculadora com menu
// O código abaixo deve exibir um menu de operações e executar a escolhida, repetindo até que o usuário deseje sair.

using System;

class Program
{
    static void Main()
    {
        bool encerrar = false;

        while (!encerrar)
        {
            Console.WriteLine("1 Somar");
            Console.WriteLine("2 Subtrair");
            Console.WriteLine("3 Multiplicar");
            Console.WriteLine("4 Dividir");
            Console.WriteLine("0 Sair");
            Console.Write("Escolha: ");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 0)
            {
                encerrar = true;
            } else
            {
                Console.WriteLine("Digite o primeiro número: ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                double y = double.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Resultado: " + (x + y));
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Resultado: " + (x - y));
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Resultado: " + (x * y));
                }
                else if (opcao == 4)
                {
                    if (x == 0 || y == 0)
                    {
                        Console.WriteLine("Divisão por zero");
                        break;
                    }

                    Console.WriteLine("Resultado: " + (x / y));
                }
            }
        }
    }
}