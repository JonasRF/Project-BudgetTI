using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetIT.Models;

namespace BudgetIT.Models
{
    public class BudgetRecord
    {
        public int Id { get; set; }
        public Fornecedor Fornecedor { get; set; }
         public Servico Servico { get; set; }
         public NotaFiscalProduto NotaFiscalProduto { get; set; }
         public NotaFiscalServico NotaFiscalServico { get; set; }
  
    }
}
