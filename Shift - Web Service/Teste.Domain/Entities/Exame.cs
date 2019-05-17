using System.Collections.Generic;

namespace Teste.Domain.Entities
{
    public class Exame : BaseEntity
    {

        public string Descricao { get; set; }

        public int IdSetor { get; set; }

        public Setor Setor { get; set; }

        public string MaterialBiologico { get; set; }

        public int Prazo { get; set; }

        public IEnumerable<OrdemServicoExame> OrdemServicoExames { get; set; }

        public IEnumerable<PrecoExame> PrecoExames { get; set; }

    }
}
