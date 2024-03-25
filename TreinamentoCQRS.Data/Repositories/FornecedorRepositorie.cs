using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Data.Context;
using TreinamentoCQRS.Domain.Entities;
using TreinamentoCQRS.Domain.Interface;

namespace TreinamentoCQRS.Data.Repositories
{
    public class FornecedorRepositorie : IFornecedorRepositorie
    {
        private readonly DataContext _DbContext;

        public FornecedorRepositorie(DataContext dbContext)
        {
            _DbContext = dbContext;
        }
        private async Task<Fornecedor> BuscarPorId(int Id)
        {
            return await _DbContext.Fornecedor.FirstAsync(x => x.Id == Id);
        }

        public async Task<Fornecedor> Adicionar(Fornecedor fornecedor)
        {
            await _DbContext.Fornecedor.AddAsync(fornecedor);

            return fornecedor;
        }

        public async Task<Fornecedor> Alterar(Fornecedor fornecedor)
        {
            var FornecedorPorId = await BuscarPorId(fornecedor.Id);

            FornecedorPorId.Nome = fornecedor.Nome;
            FornecedorPorId.Cnpj = fornecedor.Cnpj;
            FornecedorPorId.EnderecoId = fornecedor.EnderecoId;

            _DbContext.Fornecedor.Update(FornecedorPorId);

            return FornecedorPorId;
        }

        public async Task<Fornecedor> Editar(Fornecedor fornecedor)
        {
            var FornecedorPorId = await BuscarPorId(fornecedor.Id);

            FornecedorPorId.Nome = fornecedor.Nome;
            FornecedorPorId.Cnpj = fornecedor.Cnpj;
            FornecedorPorId.EnderecoId = fornecedor.EnderecoId;

            _DbContext.Fornecedor.Update(FornecedorPorId);

            return FornecedorPorId;
        }
    }
}
