using System;
using System.Collections.Generic;

namespace Teste.Domain.Entities
{
    public class Paciente : BaseEntity
    {

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Sexo { get; set; }

        public string Endereco { get; set; }

        public int IdCidade { get; set; }

        public virtual Cidade Cidade { get; set; }

        public IEnumerable<OrdemServico> OrdensServico { get; set; }

    }
}
