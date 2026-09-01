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
    public class MedicoMapping : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.ToTable("tb_Medico");
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Nome).IsRequired().HasMaxLength(100);
            builder.Property(m => m.CRM).IsRequired().HasMaxLength(20);

            builder.HasMany(m => m.Agendamentos)
                   .WithOne(a => a.Medico)
                   .HasForeignKey(a => a.MedicoId);
        }
    }

}
