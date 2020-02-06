using Domain.Entities.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Mappings
{
    public class CardEntityTypeConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.ToTable("Cards");

            builder.HasKey(c => c.Id)
                .HasName("FK_Cards_Id");

            builder.Property<int>(c => c.Id)
                .IsRequired()
                .UseIdentityColumn(1, 1)
                .HasColumnName("Id");

            builder.Property<int>(c => c.UserId)
                .IsRequired()
                .HasColumnName("UserId");

            builder.Property<string>(c => c.LastDigits)
                .HasMaxLength(4)
                .IsRequired()
                .HasColumnName("LastDigits");

            builder.Property(c => c.Type)
                .IsRequired()
                .HasConversion<int>()
                .HasColumnName("Type");

            builder.Property<DateTime>(c => c.CreatedAt)
                .IsRequired()
                .HasColumnName("CreatedAt");

            builder.Property<DateTime?>(c => c.UpdatedAt)
                .IsRequired(false)
                .HasColumnName("UpdatedAt");

            builder.Property<bool>(c => c.Disabled)
                .IsRequired()
                .HasColumnName("Disabled");
        }
    }
}
