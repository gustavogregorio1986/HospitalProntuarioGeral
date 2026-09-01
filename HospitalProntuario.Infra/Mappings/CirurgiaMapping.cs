using HospitalProntuario.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalProntuario.Infra.Mappings
{
    public class CirurgiaMapping : IEntityTypeConfiguration<Cirurgia>
    {
        public void Configure(EntityTypeBuilder<Cirurgia> builder)
        {
            builder.ToTable("tb_Cirurgia");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Data)
                   .IsRequired();

            builder.Property(c => c.Tipo)
                   .IsRequired();

            // Relacionamento com Paciente
            builder.HasOne(c => c.Paciente)
                   .WithMany(p => p.Cirurgias)
                   .HasForeignKey("PacienteId");

            builder.HasOne(c => c.Medico)
                   .WithMany(m => m.Cirurgias)
                   .HasForeignKey(c => c.MedicoId);

        }
    }
}
