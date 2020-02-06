using Domain.Entities.UserAggregate;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Infraestructure.Mappings
{
    public class FriendshipEntityTypeConfiguration : IEntityTypeConfiguration<Friendship>
    {
        public void Configure(EntityTypeBuilder<Friendship> builder)
        {
            builder.ToTable("Friendships");

            builder.HasKey(f => f.Id)
                .HasName("PK_Friendship_Id");

            builder.Property<int>(f => f.Id)
                .UseIdentityColumn(1, 1)
                .IsRequired()
                .HasColumnName("Id");

            builder.Property<int>(f => f.UserAId)
                .IsRequired()
                .HasColumnName("UserAId");

            builder.Property<int>(f => f.UserBId)
                .IsRequired()
                .HasColumnName("UserBId");

            builder.Property<Relation>(f => f.Relation)
                .IsRequired()
                .HasColumnName("Relation");

        }
    }
}
