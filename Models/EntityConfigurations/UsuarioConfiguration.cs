using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication04.Models.Entities;

namespace WebApplication04.Models.EntityConfigurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(u => u.Id);
                    
            builder.Property(u => u.Nome)
                      .IsRequired()
                      .HasMaxLength(80);

            builder.Property(u => u.Senha)
                      .IsRequired()
                      .HasMaxLength(8);

            builder.HasOne(u => u.TipoUsuario)
                   .WithMany(tu => tu.Usuarios)
                   .HasForeignKey( u => u.FkIdTipoUsuario);
        }
    }
}