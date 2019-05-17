using System;
using System.Collections.Generic;

namespace Teste.Domain.Entities
{
    public class OrdemServico : BaseEntity
    {

        public DateTime? Data { get; set; }

        public int IdPaciente { get; set; }

        public Paciente Paciente { get; set; }

        public int IdConvenio { get; set; }

        public Convenio Convenio { get; set; }

        public int IdPostoColeta { get; set; }

        public PostoColeta PostoColeta { get; set; }

        public int IdMedico { get; set; }

        public Medico Medico { get; set; }

        public IEnumerable<OrdemServicoExame> Exames { get; set; }

    }
}
