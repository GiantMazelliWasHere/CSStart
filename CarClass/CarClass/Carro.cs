using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    /// <summary>
    /// Representa a classe carro com os atributos chassis, numeroChassis, lincensePlate, cor e motor.
    /// </summary>
    internal class Carro
    {
        /// <summary>
        /// Os atributos padrões de um carro.
        /// </summary>
        private String chassis;
        private String numeroChassis;
        private String licensePlate;
        private String cor;
        private String motor;

        /// <summary>
        /// Função construtora da classe carro.
        /// </summary>
        /// <param name="chassis">Tipo do chassis</param>
        /// <param name="numeroChasis">Numero do chassis</param>
        /// <param name="licensePlate">Placa do carro</param>
        /// <param name="cor">Cor do carro</param>
        /// <param name="motor">Motor do carro</param>
        public Carro(String chassis, String numeroChasis, String licensePlate, String cor, String motor)
        {
            this.Chassis = chassis;
            this.NumeroChassis = numeroChasis;
            this.LicensePlate = licensePlate;
            this.Cor = cor;
            this.Motor = motor;
            
        }

        /// <summary>
        /// Getters e Setters do atributo chassis, numeroChassis, licensePlate, cor e motor.
        /// </summary>
        public string Chassis { get => chassis; set => chassis = value; }
        public string NumeroChassis { get => numeroChassis; set => numeroChassis = value; }
        public string LicensePlate { get => licensePlate; set => licensePlate = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Motor { get => motor; set => motor = value; }
    }
}
