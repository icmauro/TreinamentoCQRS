using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Domain.Entities;

namespace TreinamentoCQRS.Application.Members.Queries
{
    public class ProdutoQuerie : IRequest<IEnumerable<Produto>>
    {
    }
}
