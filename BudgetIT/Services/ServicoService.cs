using BudgetIT.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetIT.Services
{
    public class ServicoService
    {
        private readonly BudgetITContext _context;

        public ServicoService(BudgetITContext context)
        {
            _context = context;
        }


        public List<Servico> FindAll()
        {
           return _context.Servico.ToList();
        }
    }
}
