using System;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infrastructure.Configurations;

public class OrderProgressEntityConfiguration : IEntityTypeConfiguration<OrderProgressEntity>
{
    public void Configure(EntityTypeBuilder<OrderProgressEntity> builder)
    {
        builder
            .HasOne(op => op.Order)
            .WithOne(o => o.Progress)
            .HasForeignKey<OrderEntity>(o => o.ProgressId);

        builder
            .HasOne(op => op.OrderTripProgress)
            .WithOne(otp => otp.Progress)
            .HasForeignKey<OrderTripProgressEntity>(otp => otp.ProgressId);

        builder 
            .HasOne(op => op.OrderFinesProgress)
            .WithOne(ofp => ofp.Progress)
            .HasForeignKey<OrderFinesProgressEntity>(ofp => ofp.ProgressId);

        builder
            .HasOne(op => op.OrderPaymentProgress)
            .WithOne(opp => opp.Progress)
            .HasForeignKey<OrderPaymentProgressEntity>(opp => opp.ProgressId);
    }
}
