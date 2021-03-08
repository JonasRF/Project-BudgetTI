using BudgetIT.Models;
using BudgetIT.Services.Exception;
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

        public void Insert(Servico obj)
        {
            _context.Servico.Add(obj);
            _context.SaveChanges();
        }

        public Servico FindById(int id)
        {
           return _context.Servico.FirstOrDefault(obj => obj.Id == id);
        }

        public void Update(Servico obj)
        {
            if(! _context.Servico.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Servico.Update(obj);
                _context.SaveChanges();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbUpdateConcurrencyException(e.Message);
            }

        }
    }
}
