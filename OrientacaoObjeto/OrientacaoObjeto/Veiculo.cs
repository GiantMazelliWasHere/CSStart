using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto
{
    internal class Veiculo
    {

        private string placa;
        private int codFabrica;

        public Veiculo(int codFabrica)
        {
            this.codFabrica = codFabrica;
        }

        public string Placa { get => placa; set => placa = value; }


        /*
        public void SetPlaca(string placa)
        {
            this.placa = placa;
        }
        */

        public void Ligar()
        {
            Console.WriteLine("O veículo está ligado.");
        }
    }
}
