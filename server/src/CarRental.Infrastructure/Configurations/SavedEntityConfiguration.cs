using System;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infrastructure.Configurations;

public class SavedEntityConfiguration : IEntityTypeConfiguration<SavedEntity>
{
    public void Configure(EntityTypeBuilder<SavedEntity> builder)
    {
        throw new NotImplementedException();
    }
}
