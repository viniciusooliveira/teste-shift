using System.Collections.Generic;

namespace Teste.Domain.Entities
{
    public class PostoColeta : BaseEntity
    {

        public string Descricao { get; set; }

        public int IdBairro { get; set; }

        public Bairro Bairro { get; set; }

        public IEnumerable<OrdemServico> OrdensServico { get; set; }

    }
}
