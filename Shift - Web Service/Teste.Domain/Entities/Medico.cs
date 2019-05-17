using System.Collections.Generic;

namespace Teste.Domain.Entities
{
    public class Medico : BaseEntity
    {

        public string Nome { get; set; }

        public int IdEspecialidade { get; set; }

        public Especialidade Especialidade { get; set; }

        public IEnumerable<OrdemServico> OrdensServico { get; set; }

    }
}
