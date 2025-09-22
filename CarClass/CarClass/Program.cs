using CarClass;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro sedan = new Carro("Sedan", "ABC-124", "Preto", "v8");
            Carro suv = new Carro("SUV", "DEF-567", "Vermelho", "v12");
            Carro esporte = new Carro("Esporte", "GKL-294", "Azul", "v6");
            Carro familia = new Carro("Mini Van", "ABC-563", "Branco", "2.0 turbo");
            Carro sedan2 = new Carro("Sedan", "GNL-106", "Cinza", "v6");
            Carro conversivel = new Carro("Conversivel", "MLS-370", "Verde", "v12");
            Carro suv2 = new Carro("SUV", "ABC-666", "Rosa", "v6");
            Carro esporte2 = new Carro("Esporte", "GHL-806", "Laranja", "v8");
            Carro conversivel2 = new Carro("Conversivel", "DFM-043", "Azul", "2.0 turbo");
            Carro familia2 = new Carro("Mini Van", "ABC-906", "Preto", "v8");

            List<Carro> carros = new List<Carro>() { sedan, suv, esporte, familia, sedan2, conversivel, suv2, esporte2, conversivel2, familia2 };

            

        }
    }
}