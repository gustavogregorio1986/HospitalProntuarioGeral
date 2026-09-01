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
    public class InternacaoMapping : IEntityTypeConfiguration<Internacao>
    {
        public void Configure(EntityTypeBuilder<Internacao> builder)
        {
            builder.ToTable("tb_Internacao");
            builder.HasKey(i => i.Id);

            builder.Property(i => i.DataEntrada).IsRequired();
            builder.Property(i => i.DataSaida);

            builder.HasOne(i => i.Paciente)
               .WithMany(p => p.Internacoes)   // coleção na entidade Paciente
               .HasForeignKey(i => i.PacienteId);

        }
    }

}
