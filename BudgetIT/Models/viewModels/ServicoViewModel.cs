using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetIT.Models.viewModels
{
    public class ServicoViewModel
    {
        public Servico Servico { get; set; }
        public ICollection<Fornecedor> Fornecedor { get; set; }
    }
}
