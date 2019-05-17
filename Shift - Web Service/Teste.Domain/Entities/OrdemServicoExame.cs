using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teste.Domain.Entities
{
    public class OrdemServicoExame : BaseEntity
    {

        public int IdOrdemServico { get; set; }

        public OrdemServico OrdemServico { get; set; }

        public int IdExame { get; set; }

        public Exame Exame { get; set; }

        public TimeSpan? EntregaResultado { get; set; }

        public decimal Preco { get; set; }

        [NotMapped]
        public DateTime? DataEntrega { get; set; }

        [NotMapped]
        public string PrecoString { get {
                return this.Preco.ToString("N");
            } }

    }
}
