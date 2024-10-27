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

        //TODO continue the entity type configurations
    }
}
