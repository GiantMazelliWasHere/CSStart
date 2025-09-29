using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herancaPolimorfismo
{
    abstract class Veiculo
    {
        protected string placa;
        protected string chasis;
        protected string cor;
        protected string motor;
        protected int pessoas;


        bool motorLigado;
        protected int capacidadePessoas;
        protected float estadoDoTanque;

        public void LigarMotor()
        {
            motorLigado = true;
        }

        public void DesligarMotor()
        {
            motorLigado = false;
        }

        public int EstadoDoTanque()
        {
            return (int)(estadoDoTanque * 100);
        }

        public void AdicionarPessoas(int pessoas)
        {
            if (pessoas > capacidadePessoas)
            {
                Console.WriteLine("Lotado! Vai ter que sentar no colo do Ricardão!");
            }

            this.pessoas = pessoas;
        }

        public virtual string VerificaPessoas()
        {
            return $"Existem {this.pessoas} no {this.GetType().Name} contando com o Motorista";
        }
    }
}
