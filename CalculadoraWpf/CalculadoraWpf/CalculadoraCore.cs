using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraWpf
{
    class CalculadoraCore
    {
        double[] doubles;
        int index;

        public CalculadoraCore()
        {
            doubles = new double[8];
            index = 0;
        }

        /// <summary>
        /// função que adiciona numero no buffer
        /// </summary>
        /// <param name="valor">Valor a ser armazenado</param>
        /// <returns>Retorna falso se buffer cheio</returns>
        public bool AdicionaBuffer(double valor)
        {
            if (index >= doubles.Length) {
                return false;
            }
            doubles[index] = valor;
            index++;
            return true;
        }
        public double Processa()
        {
            double sum = 0;
            foreach(double d in doubles)
            {
                sum += d;
            }

            return sum;
        }
    }
}
