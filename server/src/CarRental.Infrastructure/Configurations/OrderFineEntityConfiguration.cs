using System;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infrastructure.Configurations;

public class OrderFineEntityConfiguration : IEntityTypeConfiguration<OrderFineEntity>
{
    public void Configure(EntityTypeBuilder<OrderFineEntity> builder)
    {
        throw new NotImplementedException();
    }
}
