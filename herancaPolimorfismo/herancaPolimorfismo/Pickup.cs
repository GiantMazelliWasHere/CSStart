using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herancaPolimorfismo
{
    internal class Pickup : Carro
    {
        float cargaMax;
        public Pickup(string placa, string modelo, string cor, string motor, float cargaMax) : base(placa, modelo, cor, motor)
        {
            capacidadePessoas = 2;
            this.cargaMax = cargaMax;
        }
    }
}
