using System;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infrastructure.Configurations;

public class OrderEntityConfiguration : IEntityTypeConfiguration<OrderEntity>
{
    public void Configure(EntityTypeBuilder<OrderEntity> builder)
    {
        builder
            .HasOne(o => o.Authentication)
            .WithOne(oa => oa.Order)
            .HasForeignKey<OrderAuthEntity>(oa => oa.OrderId);

        builder
            .HasOne(o => o.Progress)
            .WithOne(op => op.Order)
            .HasForeignKey<OrderProgressEntity>(op => op.OrderId);

        builder 
            .HasOne(o => o.Info)
            .WithOne(oi => oi.Order)
            .HasForeignKey<OrderInfoEntity>(oi => oi.OrderId);
    }
}
