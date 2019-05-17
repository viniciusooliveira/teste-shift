using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities;

namespace Teste.Service.Validators
{
    public class PacienteValidator : AbstractValidator<Paciente>
    {

        public PacienteValidator() {

            RuleFor(p => p.IdCidade)
                .GreaterThan(0).WithMessage("Você deve selecionar uma cidade.");

            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("Você deve inserir um nome.");

            RuleFor(p => p.Sexo)
                .NotEmpty().WithMessage("Você deve selecionar um sexo.");

            RuleFor(p => p.DataNascimento)
                .NotNull().WithMessage("Você deve inserir a data de nascimento.");

            RuleFor(p => p.Endereco)
                .NotEmpty().WithMessage("Você deve inserir o endereço.");

        }

    }
}
