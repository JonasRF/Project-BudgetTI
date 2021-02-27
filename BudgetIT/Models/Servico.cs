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

        public Servico()
        {
        }

        public Servico(string descricao, string tipo)
        {
            Descricao = descricao;
            Tipo = tipo;
        }
    }
}
