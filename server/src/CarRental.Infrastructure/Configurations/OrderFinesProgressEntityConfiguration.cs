using System;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infrastructure.Configurations;

public class OrderFinesProgressEntityConfiguration : IEntityTypeConfiguration<OrderFinesProgressEntity>
{
    public void Configure(EntityTypeBuilder<OrderFinesProgressEntity> builder)
    {
        builder
            .HasOne(ofp => ofp.Progress)
            .WithOne(op => op.OrderFinesProgress)
            .HasForeignKey<OrderProgressEntity>(op => op.OrderFinesProgressId);
    }
}
