using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.Domain.Entities;

namespace Teste.Infra.Data.Mapping
{
    public class PrecoExameMap : IEntityTypeConfiguration<PrecoExame>
    {
        public void Configure(EntityTypeBuilder<PrecoExame> builder)
        {
            builder.ToTable("PrecoExame");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Preco)
                .IsRequired();

            builder.HasOne(p => p.Convenio)
                .WithMany(c => c.PrecoExames)
                .HasForeignKey(p => p.IdConvenio);

            builder.HasOne(p => p.Exame)
                .WithMany(e => e.PrecoExames)
                .HasForeignKey(p => p.IdExame);

            builder.HasData(
                new PrecoExame()
                {
                    Id = 1,
                    IdConvenio = 1,
                    IdExame = 1,
                    Preco = 89.90m
                },
                new PrecoExame() {
                    Id = 2,
                    IdConvenio = 1,
                    IdExame = 2,
                    Preco = 55.00m
                },
                new PrecoExame()
                {
                    Id = 3,
                    IdConvenio = 2,
                    IdExame = 1,
                    Preco = 99.90m
                },
                new PrecoExame()
                {
                    Id = 4,
                    IdConvenio = 2,
                    IdExame = 2,
                    Preco = 60.00m
                }
            );

        }
    }
}
