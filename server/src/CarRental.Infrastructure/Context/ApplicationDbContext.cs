using System;
using CarRental.Domain.Entities;
using CarRental.Infrastructure.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Infrastructure.Context;

public class ApplicationDbContext : IdentityDbContext<UserEntity>
{
    public DbSet<AvailabilityEntity> Availability { get; set; }

    public DbSet<BlacklistEntity> Blacklist { get; set; }

    public DbSet<CarEntity> Car { get; set; }

    public DbSet<ListingEntity> Listing { get; set; }

    public DbSet<OrderAuthEntity> OrderAuth { get; set; }

    public DbSet<OrderEntity> Order { get; set; }

    public DbSet<OrderFineEntity> OrderFine { get; set; }

    public DbSet<OrderFinesProgressEntity> OrderFinesProgress { get; set; }

    public DbSet<OrderInfoEntity> OrderInfo { get; set; }

    public DbSet<OrderPaymentProgressEntity> OrderPaymentProgress { get; set; }

    public DbSet<OrderProgressEntity> OrderProgress { get; set; }

    public DbSet<OrderTripProgressEntity> OrderTripProgress { get; set; }

    public DbSet<PriceEntity> Price { get; set; }

    public DbSet<SavedEntity> Saved { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasPostgresExtension("postgis");

        modelBuilder.ApplyConfiguration(new AvailabilityEntityConfiguration());
        modelBuilder.ApplyConfiguration(new BlacklistEntityConfiguration());
        modelBuilder.ApplyConfiguration(new CarEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ListingEntityConfiguration());
        modelBuilder.ApplyConfiguration(new OrderAuthEntityConfiguration());
        modelBuilder.ApplyConfiguration(new OrderEntityConfiguration());
        modelBuilder.ApplyConfiguration(new OrderFineEntityConfiguration());
        modelBuilder.ApplyConfiguration(new OrderFinesProgressEntityConfiguration());
        modelBuilder.ApplyConfiguration(new OrderInfoEntityConfiguration());
        modelBuilder.ApplyConfiguration(new OrderPaymentProgressEntityConfiguration());
        modelBuilder.ApplyConfiguration(new OrderProgressEntityConfiguration());
        modelBuilder.ApplyConfiguration(new OrderTripProgressEntityConfiguration());
        modelBuilder.ApplyConfiguration(new PriceEntityConfiguration());
        modelBuilder.ApplyConfiguration(new SavedEntityConfiguration());
    }
}
