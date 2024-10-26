using System;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infrastructure.Configurations;

public class OrderTripProgressEntityConfiguration : IEntityTypeConfiguration<OrderTripProgressEntity>
{
    public void Configure(EntityTypeBuilder<OrderTripProgressEntity> builder)
    {
        
    }
}
