using OrientacaoObjeto;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo meuVeiculo = new Veiculo(666);
            meuVeiculo.Ligar();
            meuVeiculo.Placa = "EAI-1099";
            Console.WriteLine(meuVeiculo.Placa);

        }
    }
}