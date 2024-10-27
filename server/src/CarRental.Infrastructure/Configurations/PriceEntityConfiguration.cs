using System;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infrastructure.Configurations;

public class PriceEntityConfiguration : IEntityTypeConfiguration<PriceEntity>
{
    public void Configure(EntityTypeBuilder<PriceEntity> builder)
    {
        builder
            .HasOne(p => p.Listing)
            .WithMany(l => l.Prices)
            .HasForeignKey(p => p.ListingId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasMany(p => p.OrderInfos)
            .WithOne(oi => oi.Price)
            .HasForeignKey(oi => oi.PriceId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
