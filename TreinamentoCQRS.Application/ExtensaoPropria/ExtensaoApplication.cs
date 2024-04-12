using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Application.Members.Commands;
using TreinamentoCQRS.Domain.View;

namespace TreinamentoCQRS.Application.ExtensaoPropria
{
    public static class ExtensaoApplication
    {
        public static ProdutoView RetornaProdutoCriarViewClass(this CriarProdutoCommand produtoCommand)
        {
            return new ProdutoView
            {
                Descricao = produtoCommand.Descricao,
                Marca = produtoCommand.Marca,
                Unidade = produtoCommand.Unidade,
                Quilograma = produtoCommand.Quilograma,
                Metro = produtoCommand.Metro,
                FotoDoProduto = produtoCommand.FotoDoProduto
            };
        }

        public static ProdutoView RetornaProdutoAtualizarViewClass(this AtualizarProdutoCommand produtoCommand)
        {
            return new ProdutoView
            {
                Descricao = produtoCommand.Descricao,
                Marca = produtoCommand.Marca,
                Unidade = produtoCommand.Unidade,
                Quilograma = produtoCommand.Quilograma,
                Metro = produtoCommand.Metro,
                FotoDoProduto = produtoCommand.FotoDoProduto
            };
        }

        public static ProdutoView RetornaProdutoEditarViewClass(this EditarProdutoCommand produtoCommand)
        {
            return new ProdutoView
            {
                Descricao = produtoCommand.Descricao,
                Marca = produtoCommand.Marca,
                Unidade = produtoCommand.Unidade,
                Quilograma = produtoCommand.Quilograma,
                Metro = produtoCommand.Metro,
                FotoDoProduto = produtoCommand.FotoDoProduto
            };
        }
    }
}
