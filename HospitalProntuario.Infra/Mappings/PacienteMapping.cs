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
    public class PacienteMapping : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("tb_Paciente");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).IsRequired().HasMaxLength(100);
            builder.Property(p => p.CPF).HasMaxLength(11);

            builder.HasMany(p => p.Agendamentos)
                   .WithOne(a => a.Paciente)
                   .HasForeignKey(a => a.PacienteId);
        }
    }

}
