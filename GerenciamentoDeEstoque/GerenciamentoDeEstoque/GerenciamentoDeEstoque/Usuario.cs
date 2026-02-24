using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeEstoque
{
    // Classe para representar um usuário, implementando a interface IdIdentificavel
    public class Usuario : IdIdentificavel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // Sobrescreve o método ToString para exibir as informações do usuário de forma legível
        public override string ToString()
        {
            return $"Usuário -> Id: {Id}, Nome: {Nome}, Email: {Email}";
        }
    }
