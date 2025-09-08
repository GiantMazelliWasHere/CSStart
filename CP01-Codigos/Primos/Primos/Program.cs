//Variant 2
// Projeto de Avaliação (Revisado) - Variante 2: Verificação de número primo
// O código a seguir deve ler um número inteiro do usuário e informar se ele é primo.
// Para aumentar a dificuldade, a implementação possui erros de tipo, lógica e fluxo.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número natural: ");

        int numero = int.Parse(Console.ReadLine());
        bool ePrimo;

        ePrimo = VerificarPrimo(numero);

        if (ePrimo == true)
        {
            Console.WriteLine("O número " + numero + " é primo");
        } else
        {
            Console.WriteLine("O número " + numero + " não é primo");
        }

    }


    static bool VerificarPrimo(int n)
    {
        if (n < 2)
        {
            return false;
        }


        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}