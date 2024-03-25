using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Domain.Entities;

namespace TreinamentoCQRS.Domain.Interface
{
    public interface IEnderecoRepositorie
    {
        Task<Endereco> Adicionar(Endereco endereco);
        Task<Endereco> Alterar(Endereco endereco);
        Task<Endereco> Editar(Endereco endereco);
    }
}
