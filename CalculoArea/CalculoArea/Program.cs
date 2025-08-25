using System;

namespace MyApp
{
    internal class Program
    {
        /// Variáveis Globais
        static double b = 0;
        static double h = 0;
        static double r = 0;

        /// <summary>
        /// Print - Metodo para imprimir na tela
        /// </summary>
        /// <param name="value">mensagem a ser imprimida</param>
        static void Print(String value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Print - Metodo para imprimir na tela
        /// </summary>
        /// <param name="value">mensagem a ser imprimida</param>
        static void Print(double value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Função para calcular a area do triangulo
        /// </summary>
        /// <param name="b">base do triangulo</param>
        /// <param name="h">altura do triangulo</param>
        /// <returns>area do triangulo</returns>
        static double CalculoAreaTriangulo(double b, double h)
        {
            double area = (b * h) / 2;
            return area;
        }

        /// <summary>
        /// Função para calcular a area do retangulo
        /// </summary>
        /// <param name="b">base do retangulo</param>
        /// <param name="h">altura do retangulo</param>
        /// <returns>area do retangulo</returns>
        static double CalculoAreaRetangulo(double b, double h)
        {
            double area = b * h;
            return area;
        }

        /// <summary>
        /// Função para calcular a area do circulo
        /// </summary>
        /// <param name="r">raio do circulo</param>
        /// <returns>area do circulo</returns>
        static double CalculoAreaCirculo(double r)
        {
            double area = Math.Pow(r, 2) * Math.PI;
            return area;
        }

        static void Main(string[] args)
        {
            Print("Qual o Seu nome?");
            String nome = Console.ReadLine();

            Print("Qual Forma geometrica deseja calcular a area?");
            Print("1 - Triangulo");
            Print("2 - Retangulo");
            Print("3 - Circulo");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Print("Digite a base do triangulo: ");
                b = double.Parse(Console.ReadLine());
                Print("Digite a altura do triangulo: ");
                h = double.Parse(Console.ReadLine());
                double area = CalculoAreaTriangulo(b, h);
                Print(nome + " a area do triangulo é: ");
                Print(area);
            }
            else if (opcao == 2)
            {
                Print("Digite a base do retangulo: ");
                b = double.Parse(Console.ReadLine());
                Print("Digite a altura do retangulo: ");
                h = double.Parse(Console.ReadLine());
                double area = CalculoAreaRetangulo(b, h);
                Print(nome + " a area do retangulo é: ");
                Print(area);
            }
            else if (opcao == 3)
            {
                Print("Digite o raio do circulo: ");
                r = double.Parse(Console.ReadLine());
                double area = CalculoAreaCirculo(r);
                Print(nome + " a area do circulo é: ");
                Print(area);
            }
            else
            {
                Print("Opcao invalida!");
            }

        }
    }
}