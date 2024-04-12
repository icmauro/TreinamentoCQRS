using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Application.ExtensaoPropria;
using TreinamentoCQRS.Domain.Entities;
using TreinamentoCQRS.Domain.Interface;
using TreinamentoCQRS.Domain.View;

namespace TreinamentoCQRS.Application.Members.Commands
{
    public class AtualizarProdutoCommandHandler: IRequestHandler<AtualizarProdutoCommand, Produto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProdutoBussines _produtoBussines;

        public AtualizarProdutoCommandHandler(IUnitOfWork unitOfWork, IProdutoBussines produtoBussines)
        {
            _unitOfWork = unitOfWork;
            _produtoBussines = produtoBussines;
        }

        public async Task<Produto> Handle(AtualizarProdutoCommand request, CancellationToken cancellationToken)
        {
            var RequestProduto = await _produtoBussines.AlterarProduto(request);

            return RequestProduto;
        }
    }
}
