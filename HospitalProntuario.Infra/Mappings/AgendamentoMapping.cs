using HospitalProntuario.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Mappings
{
    public class AgendamentoMapping : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {
            builder.ToTable("tb_Agendamento");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Data).IsRequired();

            builder.HasOne(a => a.Paciente)
                   .WithMany(p => p.Agendamentos)
                   .HasForeignKey(a => a.PacienteId);

            builder.HasOne(a => a.Medico)
                   .WithMany(m => m.Agendamentos)
                   .HasForeignKey(a => a.MedicoId);
        }
    }
}
