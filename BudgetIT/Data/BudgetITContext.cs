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

        public DbSet<NotaFiscalProduto> NotaFiscalProduto { get; set; }
        public DbSet<NotaFiscalServico> NotaFiscalServico { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<FornecedorServico> FornecedorServico { get; set; }
        public DbSet<ClienteFornecedor> ClienteFornecedor { get; set; }
    }
}
