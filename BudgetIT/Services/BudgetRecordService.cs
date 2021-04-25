using BudgetIT.Models;
using BudgetIT.Models.viewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetIT.Services
{

    public class BudgetRecordService
    {
        private readonly BudgetITContext _context;

        public BudgetRecordService(BudgetITContext context)
        {
            _context = context;
        }



        public List<NotaFiscalProduto> FindById(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.NotaFiscalProduto
                         join s in _context.Servico on obj.FornecedorId equals s.Id
                         select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Emissao >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Emissao >= maxDate.Value);
            }


            return result
                .Include(x => x.Fornecedor)   
                .ToList(); 
            
        }

        public List<NotaFiscalServico> FindById1(DateTime? minDate, DateTime? maxDate)
        {
            var result1 = from obj in _context.NotaFiscalServico select obj;
            if (minDate.HasValue)
            {
                result1 = result1.Where(x => x.Emissao >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result1 = result1.Where(x => x.Emissao >= maxDate.Value);
            }

            return result1
                .Include(x => x.Fornecedor)
                .ToList();
        }
    }
}
