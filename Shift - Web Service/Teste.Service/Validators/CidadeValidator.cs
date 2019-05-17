using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities;
using Teste.Domain.Enum;

namespace Teste.Service.Validators
{
    public class CidadeValidator : AbstractValidator<Cidade>
    {

        public CidadeValidator()
        {
            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("Você deve inserir a descrição da Cidade.");

            RuleFor(c => c.Estado).IsInEnum().WithMessage("Estado inválido.");
        }

    }
}
