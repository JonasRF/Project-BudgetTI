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

        public Servico(int id, string descricao, string tipo)
        {
            Id = id;
            Descricao = descricao;
            Tipo = tipo;
        }
    }
}
