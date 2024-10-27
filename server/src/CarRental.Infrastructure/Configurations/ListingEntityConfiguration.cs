using System;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infrastructure.Configurations;

public class ListingEntityConfiguration : IEntityTypeConfiguration<ListingEntity>
{
    public void Configure(EntityTypeBuilder<ListingEntity> builder)
    {
        builder
            .HasOne(l => l.Car)
            .WithMany(c => c.Listings)
            .HasForeignKey(l => l.CarId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(l => l.User)
            .WithMany(u => u.Listings)
            .HasForeignKey(l => l.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(l => l.Prices)
            .WithOne(p => p.Listing)
            .HasForeignKey(p => p.ListingId);

        builder
            .HasMany(l => l.Savings)
            .WithOne(s => s.Listing)
            .HasForeignKey(s => s.ListingId);

        builder
            .HasMany(l => l.OrderInfos)
            .WithOne(oi => oi.Listing)
            .HasForeignKey(oi => oi.ListingId);
    }
}
