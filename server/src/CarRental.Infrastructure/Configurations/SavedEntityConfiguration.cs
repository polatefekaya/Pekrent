using System;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRental.Infrastructure.Configurations;

public class SavedEntityConfiguration : IEntityTypeConfiguration<SavedEntity>
{
    public void Configure(EntityTypeBuilder<SavedEntity> builder)
    {
        builder
            .HasOne(s => s.Listing)
            .WithMany(l => l.Savings)
            .HasForeignKey(s => s.ListingId)
            .OnDelete(DeleteBehavior.NoAction);
        
        builder
            .HasOne(s => s.User)
            .WithMany(u => u.Savings)
            .HasForeignKey(s => s.UserId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}