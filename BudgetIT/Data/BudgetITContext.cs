using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BudgetIT.Models
{
    public class BudgetITContext : DbContext
    {
        public BudgetITContext (DbContextOptions<BudgetITContext> options)
            : base(options)
        {
        }

        public DbSet<BudgetIT.Models.NotaFiscalProduto> NotaFiscalProduto { get; set; }
    }
}
