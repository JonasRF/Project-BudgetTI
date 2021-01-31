using BudgetIT.Models.Enums;
using System;
using System.Collections.Generic;

namespace BudgetIT.Models
{
    public class NotaFiscalServico
    {
        public int Id { get; set; }
        public DateTime Emissao { get; set; }
        public DateTime Vencimento { get; set; }
        public string NrNota { get; set; }
        public double Valor { get; set; }
        public string Oc { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public NotaStatus Status { get; set; }

        public NotaFiscalServico()
        {
        }

        public NotaFiscalServico(int id, DateTime emissao, DateTime vencimento, string nrNota, double valor, string oc, Fornecedor fornecedor, NotaStatus status)
        {
            Id = id;
            Emissao = emissao;
            Vencimento = vencimento;
            NrNota = nrNota;
            Valor = valor;
            Oc = oc;
            Fornecedor = fornecedor;
            Status = status;
        }
    }
}
