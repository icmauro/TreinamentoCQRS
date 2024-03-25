using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Domain.Entities;
using TreinamentoCQRS.Domain.Notificacao;
using TreinamentoCQRS.Domain.Validations.Interface;

namespace TreinamentoCQRS.Domain.Validations
{
    public class ProdutoValidation : IValidation
    {
        private Produto _produto;
        public ProdutoValidation(Produto produto)
        {
            _produto = produto;
        }
        public ProdutoValidation DescricaoIsNullOrEmpty()
        {
            if (String.IsNullOrEmpty(_produto.Descricao))
            {
                _produto.AdicionaErrors(new Error { NomeCampo = "Descricao", Mensagem = "Campo Descricao não pode estar vazio " });
            }

            return this;
        }

        public ProdutoValidation MarcaIsNullOrEmpty()
        {
            if (String.IsNullOrEmpty(_produto.Marca))
            {
                _produto.AdicionaErrors(new Error { NomeCampo = "Marca", Mensagem = "Campo Marca não pode estar vazio " });
            }

            return this;
        }

        public ProdutoValidation UnidadeIsNullOrEmpty()
        {
            if (_produto.Unidade == 0)
            {
                _produto.AdicionaErrors(new Error { NomeCampo = "Unidade", Mensagem = "Campo Unidade não pode iniciar com valor 0" });
            }

            return this;
        }

        public ProdutoValidation QuilogramaIsNullOrEmpty()
        {
            if (_produto.Quilograma == 0)
            {
                _produto.AdicionaErrors(new Error { NomeCampo = "Quilograma", Mensagem = "Campo Quilograma não pode iniciar com valor 0" });
            }

            return this;
        }

        public ProdutoValidation MetroIsNullOrEmpty()
        {
            if (_produto.Metro == 0)
            {
                _produto.AdicionaErrors(new Error { NomeCampo = "Metro", Mensagem = "Campo Metro não pode iniciar com valor 0" });
            }

            return this;
        }

        public ProdutoValidation FotoDoProdutoIsNullOrEmpty()
        {
            if (String.IsNullOrEmpty(_produto.FotoDoProduto))
            {
                _produto.AdicionaErrors(new Error { NomeCampo = "FotoDoProduto", Mensagem = "Campo FotoDoProduto não pode estar vazio " });
            }

            return this;
        }

 
        public bool IsValid()
        {
            _produto.Sucesso = false;

            return _produto.ListaDeErros.Count == 0 ? true : false;
        }
    }
}
