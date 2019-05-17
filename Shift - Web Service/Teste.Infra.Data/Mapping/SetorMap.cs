using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.Domain.Entities;

namespace Teste.Infra.Data.Mapping
{
    public class SetorMap : IEntityTypeConfiguration<Setor>
    {
        public void Configure(EntityTypeBuilder<Setor> builder)
        {
            builder.ToTable("Setor");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Descricao)
                .IsRequired();

            builder.HasData(
                new Setor()
                {
                    Id = 1,
                    Descricao = "Bioquímica"
                },
                new Setor()
                {
                    Id = 2,
                    Descricao = "Hematologia"
                }
            );

        }
    }
}
