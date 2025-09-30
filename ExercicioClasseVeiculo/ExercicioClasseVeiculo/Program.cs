using ExercicioClasseVeiculo;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] veiculos = new Veiculo[3];

            veiculos[0] = new Carro("Toyota", "Corolla", "Prata", "ABC-1234", "XYZ987654321", "1.8L");
            veiculos[1] = new Moto("Honda", "CB500", "Vermelha", "DEF-5678", "UVW123456789", "500cc");
            veiculos[2] = new Caminhao("Volvo", "FH16", "Branco", "GHI-9012", "RST654321098", "16L");

            for (int i = 0; i < veiculos.Length; i++)
            {
                veiculos[i].ExibirDetalhes();
                veiculos[i].Acelerar();
            }
        }
    }
}