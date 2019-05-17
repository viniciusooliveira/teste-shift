using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.Domain.Entities;

namespace Teste.Infra.Data.Mapping
{
    public class PostoColetaMap : IEntityTypeConfiguration<PostoColeta>
    {
        public void Configure(EntityTypeBuilder<PostoColeta> builder)
        {
            builder.ToTable("PostoColeta");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Descricao)
                .IsRequired();

            builder.HasOne(p => p.Bairro)
                .WithMany(b => b.PostosColeta)
                .HasForeignKey(p => p.IdBairro);

            builder.HasData(
                new PostoColeta()
                {
                    Id = 1,
                    IdBairro = 1,
                    Descricao = "Posto de coleta 01"
                }
            );
        }
    }
}
