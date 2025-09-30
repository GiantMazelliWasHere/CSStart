using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseVeiculo
{
    abstract class Veiculo
    {
        protected string marca;
        protected string modelo;
        protected string cor;
        protected string placa;
        protected string chasis;
        protected string motor;

        public Veiculo(string marca, string modelo, string cor, string placa, string chasis, string motor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.placa = placa;
            this.chasis = chasis;
            this.motor = motor;
        }

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Cor: {cor}, Placa: {placa}, Chasis: {chasis}, Motor: {motor}");
        }

        public virtual void Acelerar()
        {
            Console.WriteLine($"O veículo {this.GetType().Name} está acelerando.");
        }
    }
}
