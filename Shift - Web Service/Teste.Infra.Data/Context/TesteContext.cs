using Microsoft.EntityFrameworkCore;
using Teste.Domain.Entities;
using Teste.Infra.Data.Mapping;

namespace Teste.Infra.Data.Context
{
    public class TesteContext : DbContext
    {

        public DbSet<Bairro> Bairro { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Convenio> Convenio { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }
        public DbSet<Exame> Exame { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<OrdemServico> OrdemServico { get; set; }
        public DbSet<OrdemServicoExame> OrdemServicoExame { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<PostoColeta> PostoColeta { get; set; }
        public DbSet<PrecoExame> PrecoExame { get; set; }
        public DbSet<Setor> Setor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql("Server=127.0.0.1;Port=3306;Database=teste;Uid=root;Pwd=");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bairro>(new BairroMap().Configure);
            modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
            modelBuilder.Entity<Convenio>(new ConvenioMap().Configure);
            modelBuilder.Entity<Especialidade>(new EspecialidadeMap().Configure);
            modelBuilder.Entity<Exame>(new ExameMap().Configure);
            modelBuilder.Entity<Medico>(new MedicoMap().Configure);
            modelBuilder.Entity<OrdemServico>(new OrdemServicoMap().Configure);
            modelBuilder.Entity<OrdemServicoExame>(new OrdemServicoExameMap().Configure);
            modelBuilder.Entity<Paciente>(new PacienteMap().Configure);
            modelBuilder.Entity<PostoColeta>(new PostoColetaMap().Configure);
            modelBuilder.Entity<PrecoExame>(new PrecoExameMap().Configure);
            modelBuilder.Entity<Setor>(new SetorMap().Configure);
        }

    }
}
