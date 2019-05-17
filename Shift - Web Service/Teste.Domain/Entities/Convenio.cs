using System.Collections.Generic;

namespace Teste.Domain.Entities
{
    public class Convenio : BaseEntity
    {

        public string Descricao { get; set; }

        public IEnumerable<OrdemServico> OrdensServico { get; set; }

        public IEnumerable<PrecoExame> PrecoExames { get; set; }

    }
}
