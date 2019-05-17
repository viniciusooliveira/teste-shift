using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.Domain.Entities;

namespace Teste.Infra.Data.Mapping
{
    public class ExameMap : IEntityTypeConfiguration<Exame>
    {
        public void Configure(EntityTypeBuilder<Exame> builder)
        {
            builder.ToTable("Exame");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Descricao)
                .IsRequired();

            builder.Property(e => e.MaterialBiologico)
                .IsRequired();

            builder.HasOne(e => e.Setor)
                .WithMany(s => s.Exames)
                .HasForeignKey(e => e.IdSetor);

            builder.HasData(
                new Exame()
                {
                    Id = 1,
                    Descricao = "Exame de Glicose",
                    MaterialBiologico = "Sangue",
                    Prazo = 4,
                    IdSetor = 1
                },
                new Exame() {
                    Id = 2,
                    Descricao = "Hemograma",
                    MaterialBiologico = "Sangue",
                    Prazo = 3,
                    IdSetor = 2
                }
            );

        }
    }
}
