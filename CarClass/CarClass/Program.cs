using CarClass;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Criando uma lista de carros e criando 10 novos objetos carros com seus atributos.
            List<Carro> carList = new List<Carro>() {
                new Carro("Sedan", "00001", "AKU-105", "Preto", "V6"),
                new Carro("Hatch", "00002", "BLV-296", "Vermelho", "V8"),
                new Carro("SUV", "00003", "CMW-317", "Azul", "W12"),
                new Carro("Crossover", "00004", "DNX-428", "Branco", "V6"),
                new Carro("Picape", "00005", "EOY-539", "Cinza", "V8"),
                new Carro("Coupe", "00006", "FPZ-640", "Verde", "W12"),
                new Carro("Conversivel", "00007", "GQA-862", "Rosa", "V6"),
                new Carro("Perua", "00008", "HRB-862", "Laranja", "V8"),
                new Carro("Minivan", "00009", "ISC-973", "Azul", "W12"),
                new Carro("Roiadster", "00010", "JTD-084", "Preto", "V6"),
            };

            /// Loop para imprimir os detalhes de cada carro na lista.
            for (int i = 0; i < carList.Count; i++)
            {
                Console.WriteLine($"Detalhes do Carro {carList[i].Chassis}: ");
                Console.WriteLine($"Numero do chassi: {carList[i].NumeroChassis}, Placa: {carList[i].LicensePlate} Cor: {carList[i].Cor}, Motor: {carList[i].Motor}");
            }



        }
    }
}