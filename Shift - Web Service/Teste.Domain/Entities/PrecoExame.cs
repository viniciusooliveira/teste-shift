namespace Teste.Domain.Entities
{
    public class PrecoExame : BaseEntity
    {

        public int IdConvenio { get; set; }

        public Convenio Convenio { get; set; }

        public int IdExame { get; set; }

        public Exame Exame { get; set; }

        public decimal Preco { get; set; }

    }
}
