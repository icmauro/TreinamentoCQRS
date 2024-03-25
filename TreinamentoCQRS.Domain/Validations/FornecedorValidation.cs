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
    public class FornecedorValidation : IValidation
    {
        private Fornecedor _fornecedor;
        public FornecedorValidation(Fornecedor fornecedor)
        {
            _fornecedor = fornecedor;
        }

        public FornecedorValidation NomeIsNullOrEmpty()
        {
            if (String.IsNullOrEmpty(_fornecedor.Nome))
            {
                _fornecedor.ListaDeErros.Add(new Error { NomeCampo = "Nome", Mensagem = "Campo Nome não pode estar vazio " });
            }

            return this;
        }

        public FornecedorValidation CnpjIsNullOrEmpty()
        {
            if (String.IsNullOrEmpty(_fornecedor.Cnpj))
            {
                _fornecedor.ListaDeErros.Add(new Error { NomeCampo = "Cnpj", Mensagem = "Campo Cnpj não pode estar vazio " });
            }

            return this;
        }

        public FornecedorValidation EnderecoIsNullOrEmpty()
        {
            if (_fornecedor.Endereco == null)
            {
                _fornecedor.ListaDeErros.Add(new Error { NomeCampo = "Endereco", Mensagem = "Campo Nome não pode estar vazio " });
            }

            return this;
        }

        public FornecedorValidation TelefoneIsNullOrEmpty()
        {
            if (String.IsNullOrEmpty(_fornecedor.Telefone))
            {
                _fornecedor.ListaDeErros.Add(new Error { NomeCampo = "Telefone", Mensagem = "Campo telefone não pode estar vazio " });
            }

            return this;
        }

        public FornecedorValidation ProdutoIsNull()
        {

            foreach (var produto in _fornecedor.Produtos)
            {
                new ProdutoValidation(produto).DescricaoIsNullOrEmpty()
                                              .MarcaIsNullOrEmpty()
                                              .UnidadeIsNullOrEmpty()
                                              .QuilogramaIsNullOrEmpty()
                                              .MetroIsNullOrEmpty()
                                              .FotoDoProdutoIsNullOrEmpty();

                if (produto.ListaDeErros.Count > 0)
                {
                    _fornecedor.ListaDeErros.AddRange(produto.ListaDeErros);
                }
            }



            return this;
        }


        public bool IsValid()
        {
            return _fornecedor.ListaDeErros.Count == 0 ? true : false;
        }
    }
}
