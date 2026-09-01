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
    public class PagamentoMapping : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.ToTable("tb_Pagamento");
            builder.HasKey(pg => pg.Id);

            builder.Property(pg => pg.Valor).IsRequired();
            builder.Property(pg => pg.Data).IsRequired();

            builder.HasOne(pg => pg.Paciente)
                   .WithMany()
                   .HasForeignKey(pg => pg.PacienteId);
        }
    }

}
