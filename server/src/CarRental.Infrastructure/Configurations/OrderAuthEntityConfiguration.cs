using System;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infrastructure.Configurations;

public class OrderAuthEntityConfiguration : IEntityTypeConfiguration<OrderAuthEntity>
{
    public void Configure(EntityTypeBuilder<OrderAuthEntity> builder)
    {
        builder
            .HasOne(oa => oa.Order)
            .WithOne(o => o.Authentication)
            .HasForeignKey<OrderEntity>(o => o.AuthenticationId);
    }
}
