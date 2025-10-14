using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAtividade
{
    class Calculadora
    {
        double[] doubles;
        int index = 0;

        public Calculadora()
        {
            doubles = new double[8];
        }

        public bool adicionaBuffer(double valor)
        {
            if (index >= doubles.Length)
            {
                return false;
            }
            doubles[index] = valor;
            index++;
            return true;
        }

        public double soma()
        {
            double soma = 0;
            foreach (double d in doubles)
            {
                soma += d;
            }
            return soma;
        }

        public double subtrai()
        {
            double sub = 0;
            for (int i = 0; i < doubles.Length; i++)
            {
                if (sub == 0)
                {
                    sub = doubles[i];
                }
                else
                {
                    sub -= doubles[i];
                }
            }
            return sub;
        }

        public double multiplica()
        {
            if (index == 0)
            {
                return 0;
            }


            double mult = 1;
            for (int i = 0; i < index; i++)
            {
                mult *= doubles[i];
            }
            return mult;
        }

        public double divide()
        {
            double div = 1;
            for (int i = 0; i < index; i++)
            {
                if (i == 0)
                {
                    div = doubles[i];
                }
                else
                {
                    if (doubles[i] == 0)
                    {
                        return 0;
                    }
                    div /= doubles[i];
                }
            }
            return div;
        }
    }
}
