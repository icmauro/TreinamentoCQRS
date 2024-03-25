using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Domain.Entities;

namespace TreinamentoCQRS.Domain.Interface
{
    public interface IFornecedorRepositorie
    {
        Task<Fornecedor> Adicionar(Fornecedor fornecedor);
        Task<Fornecedor> Alterar(Fornecedor fornecedor);
        Task<Fornecedor> Editar(Fornecedor fornecedor);
    }
}
