using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Domain.Entities;
using TreinamentoCQRS.Domain.Interface;
using TreinamentoCQRS.Domain.View;
using TreinamentoCQRS.Application.ExtensaoPropria;

namespace TreinamentoCQRS.Application.Members.Commands
{
    public class CriarProdutoCommandHandler : IRequestHandler<CriarProdutoCommand, Produto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProdutoBussines _produtoBussines;

        public CriarProdutoCommandHandler(IUnitOfWork unitOfWork, IProdutoBussines produtoBussines)
        {
            _unitOfWork = unitOfWork;
            _produtoBussines = produtoBussines;
        }

        public async Task<Produto> Handle(CriarProdutoCommand request, CancellationToken cancellationToken)
        {
            var RequestProduto = await _produtoBussines.CadastrarProduto(request);

            return RequestProduto;
        }
    }
}
