using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    internal class Carro
    {
        private String chassis;
        private String licensePlate;
        private String cor;
        private String motor;

        public Carro(String chassis, String licensePlate, String cor, String motor)
        {
            this.chassis = chassis;
            this.licensePlate = licensePlate;
            this.cor = cor;
            this.motor = motor;
            
        }
    }
}
