using BudgetIT.Models;
using BudgetIT.Services.Exception;
using System.Collections.Generic;
using System.Linq;

namespace BudgetIT.Services
{
    public class NotaFiscalProdutoService
    {
        private readonly BudgetITContext _context;

     public NotaFiscalProdutoService(BudgetITContext context)
        {
            _context = context;
        }

        public List<NotaFiscalProduto> FindAll()
        {
            return _context.NotaFiscalProduto.ToList();
        }

        public void Insert(NotaFiscalProduto obj)
        {
            _context.NotaFiscalProduto.Add(obj);
            _context.SaveChanges();
        }

        public NotaFiscalProduto FindById(int id)
        {
            return _context.NotaFiscalProduto.FirstOrDefault(obj => obj.Id == id);
        }

        public void Update(NotaFiscalProduto obj)
        {
            if (!_context.NotaFiscalProduto.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {              
                _context.NotaFiscalProduto.Update(obj);
                _context.SaveChanges();
            }catch(DbUpdateConcurrencyException e)
            {
                throw new DbUpdateConcurrencyException(e.Message);
            }
        }

        public void Remove(int id)
        {
            var obj = _context.NotaFiscalProduto.Find(id);
            _context.NotaFiscalProduto.Remove(obj);
            _context.SaveChanges();
        }
    }
}
