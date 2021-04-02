using BudgetIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetIT.Services
{
    public class NotaFiscalServicoService
    {
        private readonly BudgetITContext _context;

        public NotaFiscalServicoService(BudgetITContext context)
        {
            _context = context;
        }

        public List<NotaFiscalServico> FindAll()
        {
            return _context.NotaFiscalServico.ToList();
        }
    }
}
