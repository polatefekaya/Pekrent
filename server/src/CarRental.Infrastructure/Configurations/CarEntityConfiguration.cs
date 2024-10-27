using System;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infrastructure.Configurations;

public class CarEntityConfiguration : IEntityTypeConfiguration<CarEntity>
{
    public void Configure(EntityTypeBuilder<CarEntity> builder)
    {
        builder
            .HasMany(c => c.Listings)
            .WithOne(l => l.Car)
            .HasForeignKey(l => l.CarId);
    }
}
