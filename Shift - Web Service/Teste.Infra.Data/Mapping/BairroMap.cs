using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.Domain.Entities;

namespace Teste.Infra.Data.Mapping
{
    public class BairroMap : IEntityTypeConfiguration<Bairro>
    {
        public void Configure(EntityTypeBuilder<Bairro> builder)
        {
            builder.ToTable("Bairro");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Descricao)
                .IsRequired();

            builder.HasOne(b => b.Cidade)
                .WithMany(c => c.Bairros)
                .HasForeignKey(b => b.IdCidade);

            builder.HasData(
                new Bairro()
                {
                    Id = 1,
                    IdCidade = 1,
                    Descricao = "Vila América"
                },
                new Bairro()
                {
                    Id = 2,
                    IdCidade = 1,
                    Descricao = "Centro"
                },
                new Bairro() {
                    Id = 3,
                    IdCidade = 2,
                    Descricao = "Vila Imperial"
                },
                new Bairro() {
                    Id = 4,
                    IdCidade = 2,
                    Descricao = "Centro"
                }
            );
        }
    }
}
