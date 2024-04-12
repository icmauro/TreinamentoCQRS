using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Domain.Entities;
using TreinamentoCQRS.Domain.Interface;
using TreinamentoCQRS.Domain.Notificacao;

namespace TreinamentoCQRS.Domain.View
{
    public class ProdutoView
    {
        public int Id { get;  set; }

        public string Descricao { get;  set; }

        public string Marca { get;  set; }

        public int Unidade { get;  set; }

        public double Quilograma { get;  set; }

        public double Metro { get;  set; }

        public string FotoDoProduto { get;  set; }

        public int? FornecedorId { get; set; }

        public virtual Fornecedor? Fornecedor { get; set; }

        public bool Sucesso { get; set; } = false;

        public ICollection<Error> ListaDeErros = new List<Error>();

        public void AdicionaErrors(Error Errors)
        {
            ListaDeErros.Add(Errors);
        }
    }
}
