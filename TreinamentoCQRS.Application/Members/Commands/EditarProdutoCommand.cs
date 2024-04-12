using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Domain.View;

namespace TreinamentoCQRS.Application.Members.Commands
{
    public sealed class EditarProdutoCommand : ProdutoCommandBase
    {
        public int Id { get; set; }

    }
}
