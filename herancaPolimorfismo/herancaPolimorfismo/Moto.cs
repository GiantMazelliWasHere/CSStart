using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herancaPolimorfismo
{
    internal class Moto : Veiculo
    {
        string modelo;
        public Moto(string placa, string modelo, string cor, string motor)
        {
            capacidadePessoas = 2;
            this.placa = placa;
            this.modelo = modelo;
            this.motor = motor;
            this.cor = cor;
            Random random = new Random();
            chasis = random.Next().ToString("0000000000");
        }

        public override string VerificaPessoas()
        {
            return $"Existem {this.pessoas} na Moto contando com o Motociclista";
        }

    }
}
