using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Domain.Entities;
using TreinamentoCQRS.Domain.Interface;
using TreinamentoCQRS.Domain.Validations;
using TreinamentoCQRS.Domain.Validations.Interface;

namespace TreinamentoCQRS.Data.BussinesLayer
{
    public  class ProdutoBussines : IProdutoBussines
    {
        private readonly IUnitOfWork _unitOfWork;

        private ProdutoValidation? _produtoValidation;
        public ProdutoBussines(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Produto> CadastrarProduto(Produto produto)
        {
            if(!OkValidado(produto))
                return produto;

            await _unitOfWork.produtoRepositorie.Adicionar(produto);

            await _unitOfWork.CommitAsync();

            return produto;
        }

        public async Task<Produto> AlterarProduto(Produto produto)
        {
            if (!OkValidado(produto))
                return produto;

            await _unitOfWork.produtoRepositorie.Alterar(produto);

            await _unitOfWork.CommitAsync();

            return produto;
        }

        public async Task<Produto> EditarProduto(Produto produto)
        {
            if (!OkValidado(produto))
                return produto;

            await _unitOfWork.produtoRepositorie.Editar(produto);

            await _unitOfWork.CommitAsync();

            return produto;
        }

        private bool OkValidado(Produto produto)
        {
            _produtoValidation = new ProdutoValidation(produto);

            return _produtoValidation.DescricaoIsNullOrEmpty()
                                     .MarcaIsNullOrEmpty()
                                     .UnidadeIsNullOrEmpty()
                                     .QuilogramaIsNullOrEmpty()
                                     .MetroIsNullOrEmpty()
                                     .FotoDoProdutoIsNullOrEmpty()
                                     .IsValid();
        }
    }
}
