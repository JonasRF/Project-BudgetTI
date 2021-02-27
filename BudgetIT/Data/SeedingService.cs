
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetIT.Models;

namespace BudgetIT.Data
{
    public class SeedingService
    {
        private BudgetITContext _context;

        public SeedingService(BudgetITContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Fornecedor.Any() || _context.NotaFiscalProduto.Any() || _context.NotaFiscalServico.Any() ||
                _context.Cliente.Any() || _context.ClienteFornecedor.Any() || _context.FornecedorServico.Any() || _context.Servico.Any())
            {
                return;
            }

            Fornecedor f1 = new Fornecedor("Auvo Tecnologia LTDA", "Auvo", "12345678", "3354678893", "123.456.78/0002-76", "34321-87", "Rua fulano de tal", "Rio de janeiro", "56123-5678", "RJ");
            Fornecedor f2 = new Fornecedor("Santo Digital LTDA", "Santo Digital", "12345678", "3354678893", "123.456.78/0002-76", "34321-87", "Rua fulano de tal", "Rio de janeiro", "56123-5678", "RJ");
           

            _context.Fornecedor.AddRange(f1, f2);


            _context.SaveChanges();


        }
    }
}
