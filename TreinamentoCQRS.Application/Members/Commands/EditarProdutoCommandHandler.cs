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
    public class EditarProdutoCommandHandler : IRequestHandler<EditarProdutoCommand, Produto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProdutoBussines _produtoBussines;

        public EditarProdutoCommandHandler(IUnitOfWork unitOfWork, IProdutoBussines produtoBussines)
        {
            _unitOfWork = unitOfWork;
            _produtoBussines = produtoBussines;
        }

        public async Task<Produto> Handle(EditarProdutoCommand request, CancellationToken cancellationToken)
        {
            var RequestProduto = await _produtoBussines.EditarProduto(request);

            return RequestProduto;
        }
    }
}
