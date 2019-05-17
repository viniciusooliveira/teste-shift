using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.Domain.Entities;
using Teste.Domain.Enum;

namespace Teste.Infra.Data.Mapping
{
    public class CidadeMap : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("Cidade");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Descricao)
                .IsRequired();

            builder.Property(c => c.Estado)
                .IsRequired();

            builder.HasData(
                new Cidade() {
                    Id = 1,
                    Descricao = "Votuporanga",
                    Estado = (EstadoEnum)25
                },
                new Cidade()
                {
                    Id = 2,
                    Descricao = "São José do Rio Preto",
                    Estado = (EstadoEnum)25
                }
            );
        }
    }
}
