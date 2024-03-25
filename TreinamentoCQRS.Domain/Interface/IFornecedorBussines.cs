using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Domain.Entities;

namespace TreinamentoCQRS.Domain.Interface
{
    public interface IFornecedorBussines
    {
        Task<Fornecedor> CadastrarFornecedor(Fornecedor fornecedor);
        Task<Fornecedor> AlterarFornecedor(Fornecedor fornecedor);
        Task<Fornecedor> EditarFornecedor(Fornecedor fornecedor);
    }
}
