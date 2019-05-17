using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.Domain.Entities;

namespace Teste.Infra.Data.Mapping
{
    public class OrdemServicoExameMap : IEntityTypeConfiguration<OrdemServicoExame>
    {
        public void Configure(EntityTypeBuilder<OrdemServicoExame> builder)
        {
            builder.ToTable("OrdemServicoExame");

            builder.HasKey(o => o.Id);

            builder.Property(o => o.EntregaResultado)
                .IsRequired();

            builder.Property(o => o.Preco)
                .IsRequired();

            builder.HasOne(o => o.OrdemServico)
                .WithMany(o => o.Exames)
                .HasForeignKey(o => o.IdOrdemServico);

            builder.HasOne(o => o.Exame)
                .WithMany(e => e.OrdemServicoExames)
                .HasForeignKey(o => o.IdExame);
            
        }
    }
}
