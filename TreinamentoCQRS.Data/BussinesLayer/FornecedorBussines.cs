using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Domain.Entities;
using TreinamentoCQRS.Domain.Interface;
using TreinamentoCQRS.Domain.Validations;

namespace TreinamentoCQRS.Data.BussinesLayer
{
    public class FornecedorBussines: IFornecedorBussines
    {
        private readonly IUnitOfWork _unitOfWork;

        private FornecedorValidation? _fornecedorValidation;
        public FornecedorBussines(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Fornecedor> CadastrarFornecedor(Fornecedor fornecedor)
        {
            if (!OkValidado(fornecedor))
                return fornecedor;

            await _unitOfWork.fornecedorRepositorie.Adicionar(fornecedor);

            await _unitOfWork.CommitAsync();

            return fornecedor;
        }

        public async Task<Fornecedor> AlterarFornecedor(Fornecedor fornecedor)
        {
            if (!OkValidado(fornecedor))
                return fornecedor;

            await _unitOfWork.fornecedorRepositorie.Alterar(fornecedor);

            await _unitOfWork.CommitAsync();

            return fornecedor;
        }

        public async Task<Fornecedor> EditarFornecedor(Fornecedor fornecedor)
        {
            if (!OkValidado(fornecedor))
                return fornecedor;

            await _unitOfWork.fornecedorRepositorie.Editar(fornecedor);

            await _unitOfWork.CommitAsync();

            return fornecedor;
        }

        private bool OkValidado(Fornecedor fornecedor)
        {
            _fornecedorValidation = new FornecedorValidation(fornecedor);

            return _fornecedorValidation.NomeIsNullOrEmpty()
                                        .CnpjIsNullOrEmpty()
                                        .EnderecoIsNullOrEmpty()
                                        .TelefoneIsNullOrEmpty()
                                        .ProdutoIsNull()
                                        .IsValid();
        }
    }
}
