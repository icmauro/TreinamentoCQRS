using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Domain.Notificacao;

namespace TreinamentoCQRS.Domain.Entities
{
    public  class Fornecedor
    { 
        public int Id { get;  set; }
        public string Nome { get;  set; }
        public string Cnpj { get;  set; }
        public virtual Endereco Endereco { get;  set; }
        public int EnderecoId { get; set; }
        public string Telefone { get;  set; }
        public List<Produto> Produtos { get; set; }
        public List<Error> ListaDeErros { get; set; } = new List<Error>();
    }
}
