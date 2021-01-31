using System;
using System.Collections.Generic;
using System.Linq;

namespace BudgetIT.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string InscEstatudal { get; set; }
        public string InscMunicipal { get; set; }
        public string CNPJ { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Municipio { get; set; }
        public string telefone { get; set; }
        public char UF { get; set; }
        public ICollection<NotaFiscalProduto> provider1 { get; set; } = new List<NotaFiscalProduto>();
        public ICollection<NotaFiscalServico> provider2 { get; set; } = new List<NotaFiscalServico>();
        public ICollection<Cliente> client { get; set; } = new List<Cliente>();
        public ICollection<ClienteFornecedor> ClienteFornecedor { get; set; }
        public ICollection<FornecedorServico> FornecedorServico { get; set; } 

        public Fornecedor()
        {
        }

        public Fornecedor(int id, string razaoSocial, string nomeFantasia, string inscEstatudal, string inscMunicipal, string cNPJ, string cEP, string logradouro, string municipio, string telefone, char uF)
        {
            Id = id;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            InscEstatudal = inscEstatudal;
            InscMunicipal = inscMunicipal;
            CNPJ = cNPJ;
            CEP = cEP;
            Logradouro = logradouro;
            Municipio = municipio;
            this.telefone = telefone;
            UF = uF;
        }

        public void AddNfProduto(NotaFiscalProduto nfp)
        {
            provider1.Add(nfp);
        }

        public void AddNfServico(NotaFiscalServico nf)
        {
            provider2.Add(nf);
        }

        public void RemoveNfProduto(NotaFiscalProduto nf)
        {
            provider1.Remove(nf);
        }

        public void RemoveNfServico(NotaFiscalServico nf)
        {
            provider2.Remove(nf);
        }

        public void AddCliente(Cliente cl)
        {
            client.Add(cl);
        }

        public double TotalProduct(DateTime inicial, DateTime final)
        {
            return provider1.Where(nf => nf.Emissao >= inicial && nf.Emissao <= final).Sum(nf => nf.Valor);
        }

        public double TotalService(DateTime inicial, DateTime final)
        {
            return provider2.Where(nf => nf.Emissao >= inicial && nf.Emissao <= final).Sum(nf => nf.Valor);
        }
    }
}
