using Domain.Entities.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Mappings
{
    public class UserScoreEntityTypeConfiguration : IEntityTypeConfiguration<UserScore>
    {
        public void Configure(EntityTypeBuilder<UserScore> builder)
        {
            builder.ToTable("UserScores");

            builder.HasKey(us => us.Id)
                .HasName("PK_UserScores_Id");

            builder.Property<int>(us => us.Id)
                .UseIdentityColumn(1, 1)
                .IsRequired()
                .HasColumnName("Id");

            builder.Property<DateTime>(us => us.CreatedAt)
                .IsRequired()
                .HasColumnName("CreatedAt");

            builder.Property<DateTime?>(us => us.UpdatedAt)
                .IsRequired(false)
                .HasColumnName("UpdatedAt");

            builder.Property<int>(us => Convert.ToInt32(us.Value))
                .IsRequired()
                .HasColumnName("Value");

            builder.Property<int>(up => up.EvaluatorId)
                .IsRequired()
                .HasColumnName("EvaluatorId");

            builder.Property<string>(us => us.Comment)
                .IsRequired()
                .HasColumnName("Comment");

        }
    }
}
