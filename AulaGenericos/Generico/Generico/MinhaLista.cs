using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Generico
{
    internal class MinhaLista<T>
    {
        public T[] itens = new T[10];
        int indice = 0;
        public void adicionarItem(T item)
        {
            itens[indice] = item;
            indice++;
            
        }

        public T pegarValor(int indice)
        {
            return itens[indice];
        }

    }
}
