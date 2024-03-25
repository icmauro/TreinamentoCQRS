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
    public class EnderecoRepositorie : IEnderecoRepositorie
    {
        private readonly DataContext _DbContext;

        public EnderecoRepositorie(DataContext dbContext)
        {
            _DbContext = dbContext;
        }

        private async Task<Endereco> BuscarPorId(int Id)
        {
            return await _DbContext.Endereco.FirstAsync(x => x.Id == Id);
        }

        public async Task<Endereco> Adicionar(Endereco endereco)
        {
            await _DbContext.Endereco.AddAsync(endereco);

            return endereco;
        }

        public async Task<Endereco> Alterar(Endereco endereco)
        {
            var EnderecoPorId = await BuscarPorId(endereco.Id);

            EnderecoPorId.Cep = endereco.Cep;
            EnderecoPorId.Logradouro = endereco.Logradouro;
            EnderecoPorId.Bairro = endereco.Bairro;
            EnderecoPorId.Localidade = endereco.Localidade;
            EnderecoPorId.Uf = endereco.Uf;


            _DbContext.Endereco.Update(EnderecoPorId);

            return EnderecoPorId;

        }

        public async Task<Endereco> Editar(Endereco endereco)
        {
            var EnderecoPorId = await BuscarPorId(endereco.Id);

            EnderecoPorId.Cep = endereco.Cep;
            EnderecoPorId.Logradouro = endereco.Logradouro;
            EnderecoPorId.Bairro = endereco.Bairro;
            EnderecoPorId.Localidade = endereco.Localidade;
            EnderecoPorId.Uf = endereco.Uf;


            _DbContext.Endereco.Update(EnderecoPorId);

            return EnderecoPorId;
        }
    }
}
