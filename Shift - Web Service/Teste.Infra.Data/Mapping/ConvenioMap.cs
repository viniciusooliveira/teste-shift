using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.Domain.Entities;

namespace Teste.Infra.Data.Mapping
{
    public class ConvenioMap : IEntityTypeConfiguration<Convenio>
    {
        public void Configure(EntityTypeBuilder<Convenio> builder)
        {
            builder.ToTable("Convenio");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Descricao)
                .IsRequired();

            builder.HasData(
                new Convenio() {
                    Id = 1,
                    Descricao = "Unimed"
                },
                new Convenio() {
                    Id = 2,
                    Descricao = "HB Saúde"
                }
            );
            
        }
    }
}
