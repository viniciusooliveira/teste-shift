using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.Domain.Entities;

namespace Teste.Infra.Data.Mapping
{
    public class PacienteMap : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("Paciente");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired();

            builder.Property(p => p.Sexo)
                .IsRequired();

            builder.Property(p => p.Endereco)
                .IsRequired();

            builder.Property(p => p.DataNascimento)
                .IsRequired()
                .HasColumnType("date");

            builder.HasOne(p => p.Cidade)
                .WithMany(c => c.Pacientes)
                .HasForeignKey(p => p.IdCidade);

            builder.HasData(
                new Paciente()
                {
                    Id = 1,
                    IdCidade = 1,
                    Nome = "Vinícius Eduardo Alves Oliveira",
                    DataNascimento = new System.DateTime(1998, 6, 17),
                    Endereco = "Rua Chile, 4219",
                    Sexo = "Masculino"
                }
            );

        }
    }
}
