using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseVeiculo
{
    internal class Moto : Veiculo
    {
        public Moto(string marca, string modelo, string cor, string placa, string chasis, string motor)
            : base(marca, modelo, cor, placa, chasis, motor)
        {
        }
        public override void Acelerar()
        {
            Console.WriteLine($"A moto de marca: {marca} e de modelo: {modelo} está acelerando.");
        }
    }
}
