using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication04.Models.Entities;

namespace WebApplication04.Models.EntityConfigurations
{
    public class UtensilioConfiguration : IEntityTypeConfiguration<Utensilio>
    {
        public void Configure(EntityTypeBuilder<Utensilio> builder)
        {
            builder.ToTable("Utensilio");

            builder.HasKey(u => u.Id);
                    
            builder.Property(u => u.Nome)
                      .IsRequired()
                      .HasMaxLength(80);

            builder.Property(u => u.QtdeEstoque)
                   .HasColumnType("TINYINT");

            builder.HasOne(u => u.TipoUtensilio)
                   .WithMany(tu => tu.Utensilios)
                   .HasForeignKey( u => u.FkIdTipoUtensilio);
        }
    }
}