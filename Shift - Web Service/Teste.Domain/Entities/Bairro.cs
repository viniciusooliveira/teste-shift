using System.Collections.Generic;

namespace Teste.Domain.Entities
{
    public class Bairro : BaseEntity
    {
        public string Descricao { get; set; }

        public int IdCidade { get; set; }

        public Cidade Cidade { get; set; }

        public IEnumerable<PostoColeta> PostosColeta { get; set; }
        
    }
}
