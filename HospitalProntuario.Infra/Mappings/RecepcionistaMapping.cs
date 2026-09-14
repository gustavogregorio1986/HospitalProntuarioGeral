using HospitalProntuario.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalProntuario.Infra.Mappings
{
    public class RecepcionistaMapping : IEntityTypeConfiguration<Recepcionista>
    {
        public void Configure(EntityTypeBuilder<Recepcionista> builder)
        {
            // Nome da Tabela no Banco
            builder.ToTable("tb_Recepcionista");

            // Chave Primária
            builder.HasKey(r => r.Id);

            // Mapeamento das Propriedades
            builder.Property(r => r.Id)
                .ValueGeneratedOnAdd();

            builder.Property(r => r.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");

            builder.Property(r => r.CPF)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnType("varchar(14)");

            builder.Property(r => r.Turno)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar(50)");

            builder.Property(r => r.Email)
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");

            // Relacionamento 1 para N (Uma Recepcionista tem vários Agendamentos)
            builder.HasMany(r => r.Agendamentos)
                .WithOne(a => a.Recepcionista)
                .HasForeignKey(a => a.RecepcionistaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}