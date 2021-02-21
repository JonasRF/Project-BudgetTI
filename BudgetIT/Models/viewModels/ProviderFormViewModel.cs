using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetIT.Models.viewModels
{
    public class ProviderFormViewModel
    {
        public Fornecedor Fornecedor { get; set; }
        public NotaFiscalProduto NotaFiscalProduto { get; set; }
        public ICollection<Fornecedor> Fornec { get; set; } = new List<Fornecedor>();

        public void AddProvider(Fornecedor fd)
        {
            Fornec.Add(fd);
        }

        public void RemoveProvider(Fornecedor fd)
        {
            Fornec.Remove(fd);
        }

        public double TotalBillingProduct(DateTime initial, DateTime final)
        {
            return Fornec.Sum(billing => billing.TotalProduct(initial, final));
        }

        public double TotalBillingService(DateTime initial, DateTime final)
        {
            return Fornec.Sum(billing => billing.TotalService(initial, final));
        }
    }
}

