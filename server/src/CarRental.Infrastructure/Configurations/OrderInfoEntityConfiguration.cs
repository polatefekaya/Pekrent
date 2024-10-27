using System;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infrastructure.Configurations;

public class OrderInfoEntityConfiguration : IEntityTypeConfiguration<OrderInfoEntity>
{
    public void Configure(EntityTypeBuilder<OrderInfoEntity> builder)
    {
        builder
            .HasOne(oi => oi.Order)
            .WithOne(o => o.Info)
            .HasForeignKey<OrderEntity>(o => o.InfoId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(oi => oi.Price)
            .WithMany(p => p.OrderInfos)
            .HasForeignKey(oi => oi.PriceId)
            .OnDelete(DeleteBehavior.NoAction);

        builder 
            .HasOne(oi => oi.Listing)
            .WithMany(l => l.OrderInfos)
            .HasForeignKey(oi => oi.ListingId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
