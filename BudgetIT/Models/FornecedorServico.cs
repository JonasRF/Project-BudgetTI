using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetIT.Models
{
    public class FornecedorServico
    {
        public int Id { get; set; }
        public int FornecedorId { get; set; }
        public int ServicoId { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Servico Servico { get; set; }

        public FornecedorServico()
        {
        }

        public FornecedorServico(int id, int fornecedorId, int servicoId, Fornecedor fornecedor, Servico servico)
        {
            Id = id;
            FornecedorId = fornecedorId;
            ServicoId = servicoId;
            Fornecedor = fornecedor;
            Servico = servico;
        }
    }
}
