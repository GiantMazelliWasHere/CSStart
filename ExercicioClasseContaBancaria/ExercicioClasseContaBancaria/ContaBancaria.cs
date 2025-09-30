using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseContaBancaria
{
    internal class ContaBancaria
    {
        protected int saldo;
        protected string titular;

        public ContaBancaria(string titular, int saldo)
        {
            this.titular = titular;
            this.saldo = saldo;
        }

        public string ExibirTitular()
        {
            return titular;
        }

        public void Depositar(int valor)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado com sucesso!");
        }

        public void Sacar(int valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente! O saque não pode ser realizado!");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso!");
            }
        }

        public int ConsultarSaldo()
        {
            return saldo;
        }
    }
}
