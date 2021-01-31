using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetIT.Models
{
    public class ClienteFornecedor
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int FornecedorId { get; set; }
        public Cliente Cliente { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public ClienteFornecedor()
        {
        }

        public ClienteFornecedor(int id, int clienteId, int fornecdorId, Cliente cliente, Fornecedor fornecedor)
        {
            Id = id;
            ClienteId = clienteId;
            FornecedorId = fornecdorId;
            Cliente = cliente;
            Fornecedor = fornecedor;
        }
    }
}
