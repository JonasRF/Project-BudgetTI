using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetIT.Models
{
    public class NotaFiscalProduto
    {
        public int Id { get; set; }
        public DateTime Emissao { get; set; }
        public DateTime Vencimento { get; set; }
        public string NrNota { get; set; }
        public double Valor { get; set; }
        public string Oc { get; set; }

        public NotaFiscalProduto()
        {
        }

        public NotaFiscalProduto(int id, DateTime emissao, DateTime vencimento, string nrNota, double valor, string oc)
        {
            Id = id;
            Emissao = emissao;
            Vencimento = vencimento;
            NrNota = nrNota;
            Valor = valor;
            Oc = oc;
        }

    }
}
