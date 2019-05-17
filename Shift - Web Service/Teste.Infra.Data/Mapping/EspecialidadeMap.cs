using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.Domain.Entities;

namespace Teste.Infra.Data.Mapping
{
    public class EspecialidadeMap : IEntityTypeConfiguration<Especialidade>
    {
        public void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            builder.ToTable("Especialidade");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Descricao)
                .IsRequired();

            builder.HasData(
                new Especialidade()
                {
                    Id = 1,
                    Descricao = "Dermatologia"
                },
                new Especialidade()
                {
                    Id = 2,
                    Descricao = "Neurologia"
                },
                new Especialidade()
                {
                    Id = 3,
                    Descricao = "Pediatria"
                }
            );

        }
    }
}
