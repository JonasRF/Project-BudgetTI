using System;
using System.Collections.Generic;
using System.Linq;

namespace BudgetIT.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string InscEstatudal { get; set; }
        public string InscMunicipal { get; set; }
        public string CNPJ { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Telefone { get; set; }
        public char UF { get; set; }
        public string Filial { get; set; }
       
        public Cliente()
        {
        }

        public Cliente(int id, string razaoSocial, string nomeFantasia, string inscEstatudal, string inscMunicipal, string cNPJ, string cEP, string logradouro, string bairro, string telefone, char uF, string filial)
        {
            Id = id;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            InscEstatudal = inscEstatudal;
            InscMunicipal = inscMunicipal;
            CNPJ = cNPJ;
            CEP = cEP;
            Logradouro = logradouro;
            Bairro = bairro;
            Telefone = telefone;
            UF = uF;
            Filial = filial;
        }

    }
}
