using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoCQRS.Extensoes.Extensoes
{
    public static class ExtensoesGlobais
    {
        public static Produto RetornaProdutoClass(this ProdutoView produtoView)
        {
            return new Produto
            {
                Descricao = produtoView.Descricao,
                Marca = produtoView.Marca,
                Unidade = produtoView.Unidade,
                Quilograma = produtoView.Quilograma,
                Metro = produtoView.Metro,
                FotoDoProduto = produtoView.FotoDoProduto
            };
        }

    }
}
