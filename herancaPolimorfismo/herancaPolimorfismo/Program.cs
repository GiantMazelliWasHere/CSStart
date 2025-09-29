using herancaPolimorfismo;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] veiculos = new Veiculo[4];

            veiculos[0] = new Carro("dbd-1234", "Fusca", "Azul", "1.6");
            veiculos[1] = new Moto("abc-1234", "Honda CG", "Vermelha", "150cc");
            veiculos[2] = new Moto("xyz-5678", "Yamaha YBR", "Preta", "160cc");
            veiculos[3] = new Pickup("pqr-9876", "Ford Ranger", "Branco", "3.2", 1000);

            for (int i = 0; i < veiculos.Length; i++)
            {
                veiculos[i].LigarMotor();
                veiculos[i].AdicionarPessoas(2);
                Console.WriteLine(veiculos[i].VerificaPessoas());
            }


        }
    }
}