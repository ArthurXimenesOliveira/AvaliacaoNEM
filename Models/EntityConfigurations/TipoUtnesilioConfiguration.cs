using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication04.Models.Entities;

namespace WebApplication04.Models.EntityConfigurations
{
    public class TipoUtnesilioConfiguration : IEntityTypeConfiguration<TipoUtensilio>
    {
        public void Configure(EntityTypeBuilder<TipoUtensilio> builder)
        {
            builder.ToTable("TipoUtensilio");

            builder.HasKey(tu => tu.Id);
                    
            builder.Property(tu => tu.Nome)
                      .IsRequired()
                      .HasMaxLength(80);
        }
    }
}