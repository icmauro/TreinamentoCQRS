using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Domain.Entities;
using TreinamentoCQRS.Domain.View;

namespace TreinamentoCQRS.Application.Members.Commands
{
    public abstract class ProdutoCommandBase : IRequest<Produto>
    {
        public string Descricao { get; set; }

        public string Marca { get; set; }

        public int Unidade { get; set; }

        public double Quilograma { get; set; }

        public double Metro { get; set; }

        public string FotoDoProduto { get; set; }

        public int? FornecedorId { get; set; }
    }
}
