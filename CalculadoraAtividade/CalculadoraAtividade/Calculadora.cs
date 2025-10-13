using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Converters;

namespace CalculadoraAtividade
{
    class Calculadora
    {
        double[] doubles;
        int index = 0;

        public Calculadora()
        {
            doubles = new double[8];
        }

        public bool AdicionaBuffer(double valor)
        {
            if (index >= doubles.Length)
            {
                return false;
            }
            doubles[index] = valor;
            index++;
            return true;
        }


        public double Somar()
        {
            double sum = 0;
            foreach (double d in doubles)
            {
                sum += d;
            }
            return sum;

        }

        public double Sub()
        {
            double sub = 0;
            foreach (double d in doubles)
            {
                sub -= d;
            }
            return sub;

        }

        public double Mult()
        {
            double mult = 1;
            foreach (double d in doubles)
            {
                mult = mult * d;
            }
            return mult;

        }
        public double Div()
        {
            double div = 1;
            foreach (double d in doubles)
            {
                div = div / d;
                
            }

            return div;
        }
    }
}
