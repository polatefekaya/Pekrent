using System;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infrastructure.Configurations;

public class OrderFinesProgressEntityConfiguration : IEntityTypeConfiguration<OrderFinesProgressEntity>
{
    public void Configure(EntityTypeBuilder<OrderFinesProgressEntity> builder)
    {
        
    }
}
