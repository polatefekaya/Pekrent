using System;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infrastructure.Configurations;

public class BlacklistEntityConfiguration : IEntityTypeConfiguration<BlacklistEntity>
{
    public void Configure(EntityTypeBuilder<BlacklistEntity> builder)
    {
        builder
            .HasOne(a => a.User)
            .WithOne(e => e.Blacklist)
            .HasForeignKey<UserEntity>(a => a.BlacklistId);
    }
}
