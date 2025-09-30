using ExercicioClasseContaBancaria;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria[] contas = new ContaBancaria[3];

            contas[0] = new ContaBancaria("João", 1000);
            contas[1] = new ContaBancaria("Maria", 2000);
            contas[2] = new ContaBancaria("Pedro", 3000);
            for (int i = 0; i < contas.Length; i++)
            {
                Console.WriteLine($"Titular: {contas[i].ExibirTitular()}, Saldo: {contas[i].ConsultarSaldo()}");
            }

            contas[0].Depositar(500);
            contas[1].Depositar(500);
            contas[2].Depositar(500);

            for (int i = 0; i < contas.Length; i++)
            {
                Console.WriteLine($"Titular: {contas[i].ExibirTitular()}, Saldo: {contas[i].ConsultarSaldo()}");
            }

            contas[0].Sacar(200);
            contas[1].Sacar(2500);
            contas[2].Sacar(10000);

            for (int i = 0; i < contas.Length; i++)
            {
                Console.WriteLine($"Titular: {contas[i].ExibirTitular()}, Saldo: {contas[i].ConsultarSaldo()}");
            }



        }
    }
}