using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoCQRS.Application.Members.Commands.Validations
{
    public class CriarProdutoCommandValidator :  AbstractValidator<CriarProdutoCommand>
    {
        public CriarProdutoCommandValidator()
        {
            RuleFor(x => x.Descricao)
                .NotEmpty().WithMessage("Campo Descrição Obrigatorio")
                .Length(1,1000).WithMessage("Campo Descrição deve ter entre 1 a 150 caracteres.");

            RuleFor(x => x.Marca)
                .NotEmpty().WithMessage("Campo Marca Obrigatorio")
                .Length(1, 150).WithMessage("Campo Descrição deve ter entre 1 a 150 caracteres.");

            RuleFor(x => x.Unidade)
                .NotEmpty().WithMessage("Campo Unidade Obrigatorio");

            RuleFor(x => x.Quilograma)
                .NotEmpty().WithMessage("Campo Quilograma Obrigatorio");

            RuleFor(x => x.Metro)
                .NotEmpty().WithMessage("Campo Metro Obrigatorio");
        }
    }
}
