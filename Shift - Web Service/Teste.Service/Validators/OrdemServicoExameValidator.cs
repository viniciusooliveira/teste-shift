using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities;

namespace Teste.Service.Validators
{
    public class OrdemServicoExameValidator : AbstractValidator<OrdemServicoExame>
    {

        public OrdemServicoExameValidator()
        {
            RuleFor(o => o.EntregaResultado)
                .NotNull().WithMessage("Você deve inserir o prazo de entrega do exame.");

            RuleFor(o => o.IdExame)
                .GreaterThan(0).WithMessage("Você deve selecionar um exame.");

            RuleFor(o => o.Preco)
                .GreaterThanOrEqualTo(0).WithMessage("Você deve inserir um preço maior ou igual a zero.");
        }

    }
}
