using HospitalProntuario.Domain.Domain;
using HospitalProntuario.Infra.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            :base(options)
        {
            
        }

        public DbSet<Agendamento> Agendamentos { get; set; }

        public DbSet<Cirurgia> Cirurgias { get; set; }

        public DbSet<Internacao> Internacoes { get; set; }

        public DbSet<Medico> Medicos { get; set; }

        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Pagamento> Pagamentos { get; set; }

        public DbSet<PlanoSaude> PlanosSaude { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PacienteMapping());
            modelBuilder.ApplyConfiguration(new MedicoMapping());
            modelBuilder.ApplyConfiguration(new AgendamentoMapping());
            modelBuilder.ApplyConfiguration(new CirurgiaMapping());
            modelBuilder.ApplyConfiguration(new InternacaoMapping());
            modelBuilder.ApplyConfiguration(new PagamentoMapping());
            modelBuilder.ApplyConfiguration(new PlanoSaudeMapping());
        }

    }
}
