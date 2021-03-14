using System.Collections.Generic;


namespace BudgetIT.Models.viewModels
{
    public class NotaFiscalProdutoViewModel
    {
        public NotaFiscalProduto NotaFiscalProduto { get; set; }
        public ICollection<Fornecedor> Fornecedor { get; set; }
    }
}
