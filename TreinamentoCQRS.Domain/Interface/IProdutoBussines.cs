using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Domain.Entities;

namespace TreinamentoCQRS.Domain.Interface
{
    public interface IProdutoBussines
    {
        Task<Produto> CadastrarProduto(Produto produto);
        Task<Produto> AlterarProduto(Produto produto);
        Task<Produto> EditarProduto(Produto produto);
    }
}
