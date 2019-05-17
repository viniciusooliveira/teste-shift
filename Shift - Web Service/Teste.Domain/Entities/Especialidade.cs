using System.Collections.Generic;

namespace Teste.Domain.Entities
{
    public class Especialidade : BaseEntity
    {

        public string Descricao { get; set; }

        public IEnumerable<Medico> Medicos { get; set; }

    }
}
