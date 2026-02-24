using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeEstoque
{
    // Classe para representar um produto, implementando a interface IdIdentificavel
    public class Produto : IdIdentificavel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double Preco { get; set; }

        // Sobrescreve o método ToString para exibir as informações do produto de forma legível
        public override string ToString()
        {
            return $"Produto -> Id: {Id}, Nome: {Nome}, Preço: R${Preco}";
        }
    }
}
