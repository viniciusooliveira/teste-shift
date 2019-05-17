using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Teste.Domain.Entities;

namespace Teste.Infra.Data.Mapping
{
    public class OrdemServicoMap : IEntityTypeConfiguration<OrdemServico>
    {
        public void Configure(EntityTypeBuilder<OrdemServico> builder)
        {
            builder.ToTable("OrdemServico");

            builder.HasKey(o => o.Id);

            builder.Property(o => o.Data)
                .IsRequired()
                .HasDefaultValue(DateTime.Now)
                .HasColumnType("date");

            builder.HasOne(o => o.Paciente)
                .WithMany(p => p.OrdensServico)
                .HasForeignKey(o => o.IdPaciente);

            builder.HasOne(o => o.Convenio)
                .WithMany(c => c.OrdensServico)
                .HasForeignKey(o => o.IdConvenio);

            builder.HasOne(o => o.PostoColeta)
                .WithMany(p => p.OrdensServico)
                .HasForeignKey(o => o.IdPostoColeta);

            builder.HasOne(o => o.Medico)
                .WithMany(m => m.OrdensServico)
                .HasForeignKey(o => o.IdMedico);
            
        }
    }
}
