using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Domain.Entities;

namespace TreinamentoCQRS.Domain.Interface
{
    public interface IProdutoDapperRepositorie
    {
        Task<IEnumerable<Produto>> ListarProdutos();
        Task<Produto> BuscarProdutoPorId(int id);
    }
}
