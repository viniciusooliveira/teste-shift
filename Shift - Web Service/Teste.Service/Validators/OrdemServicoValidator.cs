using FluentValidation;
using Teste.Domain.Entities;

namespace Teste.Service.Validators
{
    public class OrdemServicoValidator : AbstractValidator<OrdemServico>
    {
        public OrdemServicoValidator()
        {

            RuleFor(o => o.IdConvenio)
                .GreaterThan(0).WithMessage("Você deve selecionar um convênio.");

            RuleFor(o => o.IdMedico)
                .GreaterThan(0).WithMessage("Você deve selecionar um médico.");

            RuleFor(o => o.IdPaciente)
                .GreaterThan(0).WithMessage("Você deve selecionar um paciente.");

            RuleFor(o => o.IdPostoColeta)
                .GreaterThan(0).WithMessage("Você deve selecionar um posto de coleta.");
        }
    }
}
