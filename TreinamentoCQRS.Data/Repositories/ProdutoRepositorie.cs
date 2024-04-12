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
    public class ProdutoRepositorie : IProdutoRepositorie
    {
        private readonly DataContext _DbContext;

        public ProdutoRepositorie(DataContext dbContext)
        {
            _DbContext = dbContext;
        }

        private async Task<Produto> BuscarPorId(int Id)
        {
            var Produto = await _DbContext.Produtos.FirstOrDefaultAsync(x => x.Id == Id);

            if (Produto == null)
                return null;

            return Produto;        
        }

        public async Task<Produto> Adicionar(Produto produto)
        {
            await _DbContext.Produtos.AddAsync(produto);

            return produto;
        }

        public async Task<Produto> Alterar(Produto produto)
        {
            var ProdutoPorId = await BuscarPorId(produto.Id);

            if (ProdutoPorId == null)
                return null;

            ProdutoPorId.Descricao = produto.Descricao;
            ProdutoPorId.Marca = produto.Marca;
            ProdutoPorId.Unidade = produto.Unidade;
            ProdutoPorId.Quilograma = produto.Quilograma;
            ProdutoPorId.Metro = produto.Metro;
            ProdutoPorId.FotoDoProduto = produto.FotoDoProduto;
            ProdutoPorId.FornecedorId = produto.FornecedorId;

            _DbContext.Produtos.Update(ProdutoPorId);

            return ProdutoPorId;

        }

        public async Task<Produto> Editar(Produto produto)
        {
            var ProdutoPorId = await BuscarPorId(produto.Id);

            if (ProdutoPorId == null)
                return null;

            ProdutoPorId.Descricao = produto.Descricao;
            ProdutoPorId.Marca = produto.Marca;
            ProdutoPorId.Unidade = produto.Unidade;
            ProdutoPorId.Quilograma = produto.Quilograma;
            ProdutoPorId.Metro = produto.Metro;
            ProdutoPorId.FotoDoProduto = produto.FotoDoProduto;
            ProdutoPorId.FornecedorId = produto.FornecedorId;

            _DbContext.Produtos.Update(ProdutoPorId);

            return ProdutoPorId;
        }
    }
}
