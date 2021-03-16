using System;
using System.Collections.Generic;
using System.Linq;

namespace BudgetIT.Models
{
    public class Servico
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int FornecedorId { get; set; }

        public Servico()
        {
        }

        public Servico(string descricao, string tipo, Fornecedor fornecedor)
        {
            Descricao = descricao;
            Tipo = tipo;
            Fornecedor = fornecedor;
        }
    }
}
