using System;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infrastructure.Configurations;

public class OrderProgressEntityConfiguration : IEntityTypeConfiguration<OrderProgressEntity>
{
    public void Configure(EntityTypeBuilder<OrderProgressEntity> builder)
    {
        
    }
}
