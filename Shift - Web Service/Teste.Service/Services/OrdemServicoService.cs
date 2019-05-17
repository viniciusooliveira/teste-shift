using System;
using System.Collections.Generic;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Teste.Domain.Entities;
using Teste.Service.Validators;

namespace Teste.Service.Services
{
    public class OrdemServicoService : BaseService<OrdemServico>
    {
        public override OrdemServico Post<V>(OrdemServico model){

            model.Data = DateTime.Now;

            model.Convenio = null;
            model.Medico = null;
            model.Paciente = null;
            model.PostoColeta = null;

            foreach(var exame in model.Exames)
            {
                var exameValidator = new OrdemServicoExameValidator();
                exameValidator.ValidateAndThrow(exame);
                exame.Exame = null;
            }

            return base.Post<V>(model);
        }

    }
}
