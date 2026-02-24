using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeEstoque
{
    // Classe para representar um pedido, implementando a interface IdIdentificavel
    public class Pedido : IdIdentificavel
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public double ValorTotal { get; set; }

        // Sobrescreve o método ToString para exibir as informações do pedido de forma legível
        public override string ToString()
        {
            return $"Pedido -> Id: {Id}, Descrição: {Descricao}, Valor Total: R${ValorTotal}";
        }
    }
}
