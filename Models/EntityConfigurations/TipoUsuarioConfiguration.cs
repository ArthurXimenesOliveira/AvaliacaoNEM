using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication04.Models.Entities;

namespace WebApplication04.Models.EntityConfigurations
{
    public class TipoUsuarioConfiguration : IEntityTypeConfiguration<TipoUsuario>
    {
        public void Configure(EntityTypeBuilder<TipoUsuario> builder)
        {
            builder.ToTable("TipoUsuario");

            builder.HasKey(tu => tu.Id);
                    
            builder.Property(tu => tu.Nome)
                      .IsRequired()
                      .HasMaxLength(80);

            
        }
        
    }
}