using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoCQRS.Domain.Interface
{
    public interface IUnitOfWork
    {
        IFornecedorRepositorie fornecedorRepositorie { get; }
        IProdutoRepositorie produtoRepositorie { get; }

        IEnderecoRepositorie enderecoRepositorie { get; }
        Task CommitAsync();
    }
}
