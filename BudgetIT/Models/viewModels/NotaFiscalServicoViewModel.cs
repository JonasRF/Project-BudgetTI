using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetIT.Models.viewModels
{
    public class NotaFiscalServicoViewModel
    {
        public NotaFiscalServico NotaFiscalServico { get; set; }
        public ICollection<Fornecedor> Fornecedor { get; set; }
    }
}
