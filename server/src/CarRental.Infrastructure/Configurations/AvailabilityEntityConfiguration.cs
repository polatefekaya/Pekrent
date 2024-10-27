using System;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infrastructure.Configurations;

public class AvailabilityEntityConfiguration : IEntityTypeConfiguration<AvailabilityEntity>
{
    public void Configure(EntityTypeBuilder<AvailabilityEntity> builder)
    {
        builder
            .HasOne(a => a.User)
            .WithOne(e => e.Availability)
            .HasForeignKey<UserEntity>(a => a.AvailabilityId);
    }
}
