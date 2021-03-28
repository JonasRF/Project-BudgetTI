using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetIT.Models
{
    public class BudgetRecord
    {
         public Fornecedor Fornecedor { get; set; }
         public Servico Servico { get; set; }
         public NotaFiscalProduto NotaFiscalProduto { get; set; }
         public NotaFiscalServico NotaFiscalServico { get; set; }
    }
}
