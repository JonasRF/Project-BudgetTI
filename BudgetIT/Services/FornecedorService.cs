using BudgetIT.Models;
using System.Collections.Generic;
using System.Linq;
using BudgetIT.Services.Exception;

namespace BudgetIT.Services
{
    public class FornecedorService
    {
        private readonly BudgetITContext _context;

        public FornecedorService(BudgetITContext context)
        {
            _context = context;
        }

        public List<Fornecedor> FindAll()
        {
            return _context.Fornecedor.ToList();
        }

        public void Insert(Fornecedor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Fornecedor FindById(int id)
        {
            return _context.Fornecedor.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Fornecedor.Find(id);
            _context.Fornecedor.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Fornecedor obj)
        {
            if(!_context.Fornecedor.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Fornecedor.Update(obj);
                _context.SaveChanges();
            }catch(DbUpdateConcurrencyException e)
            {
                throw new DbUpdateConcurrencyException(e.Message);
            }
        }

        
    }
}
