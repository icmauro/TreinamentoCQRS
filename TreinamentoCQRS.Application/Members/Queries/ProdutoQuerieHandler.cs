using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Domain.Entities;
using TreinamentoCQRS.Domain.Interface;

namespace TreinamentoCQRS.Application.Members.Queries
{
    public class ProdutoQuerieHandler : IRequestHandler<ProdutoQuerie, IEnumerable<Produto>>
    {
        private readonly IProdutoDapperRepositorie _produtoDapperRepositorie;

        public ProdutoQuerieHandler(IProdutoDapperRepositorie produtoDapperRepositorie)
        {
            _produtoDapperRepositorie = produtoDapperRepositorie;
        }

        public async Task<IEnumerable<Produto>> Handle(ProdutoQuerie request, CancellationToken cancellationToken)
        {
            return await _produtoDapperRepositorie.ListarProdutos();
        }
    }
}
