using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Domain.Entities;

namespace TreinamentoCQRS.Domain.Interface
{
    public interface IProdutoRepositorie
    {
        Task<Produto> Adicionar(Produto produto);
        Task<Produto> Alterar(Produto produto);
        Task<Produto> Editar(Produto produto);
    }
}
