using System;
using System.Collections.Generic;
using System.Linq;

namespace BudgetIT.Models
{
    public class Servico
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public ICollection<Fornecedor> Fornecedores { get; set; } = new List<Fornecedor>();
        public ICollection<FornecedorServico> FornecedorServico { get; set; }

        public Servico()
        {
        }

        public Servico(int id, string descricao, string tipo)
        {
            Id = id;
            Descricao = descricao;
            Tipo = tipo;
        }

        public void AddProvider(Fornecedor fn)
        {
            Fornecedores.Add(fn);
        }

        public void RemoveProvider(Fornecedor fn)
        {
            Fornecedores.Remove(fn);
        }

        public void TotalBillingProd(DateTime inicial, DateTime final)
        {
            Fornecedores.Sum(billing => billing.TotalProduct(inicial, final));
        }

        public void TotalBillingServ(DateTime inicial, DateTime final)
        {
            Fornecedores.Sum(billing => billing.TotalService(inicial, final));
        }
    }
}
