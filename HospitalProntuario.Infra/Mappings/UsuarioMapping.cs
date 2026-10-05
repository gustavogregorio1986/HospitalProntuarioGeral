using HospitalProntuario.Domain.Domain;
using HospitalProntuario.Domain.Domain.Usuario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("tb_Usuarios");

            // Primary Key
            builder.HasKey(e => e.Id);

            // Dagiti rason wenno configuration dagiti property
            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(e => e.PasswordHash)
                .IsRequired();

            builder.Property(e => e.Perfil)
                .IsRequired();

            builder.Property(e => e.Ativo)
                .IsRequired();

            builder.Property(e => e.DataCriacao)
                .IsRequired();

            builder.HasOne<Medico>()
                    .WithMany()
                    .HasForeignKey(e => e.MedicoId)
                    .IsRequired(false);

            builder.HasOne<Recepcionista>()
                .WithMany()
                .HasForeignKey(e => e.RecepcionistaId)
                .IsRequired(false);
        }
    }
}
