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
    public class PlanoSaudeMapping : IEntityTypeConfiguration<PlanoSaude>
    {
        public void Configure(EntityTypeBuilder<PlanoSaude> builder)
        {
            builder.ToTable("tb_PlanoSaude");
            builder.HasKey(ps => ps.Id);

            builder.Property(ps => ps.Nome).IsRequired().HasMaxLength(100);

            builder.HasMany(ps => ps.Pacientes)
                   .WithOne(p => p.PlanoSaude)
                   .HasForeignKey(p => p.PlanoSaudeId);
        }
    }

}
