using System.Collections.Generic;

namespace Teste.Domain.Entities
{
    public class Setor : BaseEntity
    {

        public string Descricao { get; set; }

        public IEnumerable<Exame> Exames { get; set; }

    }
}
