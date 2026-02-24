using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeEstoque
{
    // Interface para garantir que as classes Produto, Pedido e Usuario tenham um Id
    public interface IdIdentificavel
    {
        int Id { get; set; }
    }
}
