using System.Collections.Generic;
using Teste.Domain.Enum;

namespace Teste.Domain.Entities
{
    public class Cidade : BaseEntity
    {

        public string Descricao { get; set; }

        public EstadoEnum Estado { get; set; }

        public IEnumerable<Paciente> Pacientes { get; set; }

        public IEnumerable<Bairro> Bairros { get; set; }

    }
}
