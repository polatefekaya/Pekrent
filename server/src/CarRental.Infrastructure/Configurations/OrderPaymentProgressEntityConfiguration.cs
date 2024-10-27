using System;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infrastructure.Configurations;

public class OrderPaymentProgressEntityConfiguration : IEntityTypeConfiguration<OrderPaymentProgressEntity>
{
    public void Configure(EntityTypeBuilder<OrderPaymentProgressEntity> builder)
    {
        builder
            .HasOne(opp => opp.Progress)
            .WithOne(p => p.OrderPaymentProgress)
            .HasForeignKey<OrderProgressEntity>(p => p.OrderPaymentProgressId);
    }
}
