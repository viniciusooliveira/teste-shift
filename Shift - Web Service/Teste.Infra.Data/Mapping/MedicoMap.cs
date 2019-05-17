using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.Domain.Entities;

namespace Teste.Infra.Data.Mapping
{
    public class MedicoMap : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.ToTable("Medico");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Nome)
                .IsRequired();

            builder.HasOne(m => m.Especialidade)
                .WithMany(e => e.Medicos)
                .HasForeignKey(m => m.IdEspecialidade);

            builder.HasData(
                new Medico() {
                    Id = 1,
                    IdEspecialidade = 1,
                    Nome = "Daniela Aline Aurora Costa"
                },
                new Medico() {
                    Id = 2,
                    IdEspecialidade = 2,
                    Nome = "Francisco Eduardo Lucca Teixeira"
                },
                new Medico() {
                    Id = 3,
                    IdEspecialidade = 3,
                    Nome = "Giovanni Matheus Santos"
                }
            );

        }
    }
}
