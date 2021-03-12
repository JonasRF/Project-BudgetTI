using BudgetIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            obj.Fornecedor = _context.Fornecedor.First();
            _context.NotaFiscalProduto.Add(obj);
            _context.SaveChanges();
        }

    }
}
