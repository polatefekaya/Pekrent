using System;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infrastructure.Configurations;

public class OrderInfoEntityConfiguration : IEntityTypeConfiguration<OrderInfoEntity>
{
    public void Configure(EntityTypeBuilder<OrderInfoEntity> builder)
    {
        throw new NotImplementedException();
    }
}
