using Domain.Entities.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Mappings
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id)
                .HasName("PK_Users_Id");

            builder.Property<int>(u => u.Id)
                .IsRequired()
                .UseIdentityColumn(1, 1)
                .HasColumnName("Id");

            builder.Property<DateTime>(u => u.CreatedAt)
                .IsRequired()
                .HasColumnName("CreatedAt");

            builder.Property<DateTime?>(u => u.UpdatedAt)
                .IsRequired(false)
                .HasColumnName("UpdatedAt");

            builder.Property<string>(u => u.Name)
                .HasMaxLength(255)
                .IsRequired()
                .HasColumnName("Name");

            builder.Property<string>(u => u.Surname)
                .HasMaxLength(255)
                .IsRequired()
                .HasColumnName("Surname");

            builder.Property<string>(u => u.Email)
                .HasMaxLength(255)
                .IsRequired()
                .HasColumnName("Email");

            builder.Property<DateTime>(u => u.Birthdate)
                .IsRequired()
                .HasColumnName("Birthdate");
        }
    }
}
