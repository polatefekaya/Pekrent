using System;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Infrastructure.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<AvailabilityEntity> Availability {get; set;}
    
    public DbSet<BlacklistEntity> Blacklist {get; set;}

    public DbSet<CarEntity> Car {get; set;}

    public DbSet<ListingEntity> Listing {get; set;}

    public DbSet<OrderAuthEntity> OrderAuth {get; set;}

    public DbSet<OrderEntity> Order {get; set;}

    public DbSet<OrderFineEntity> OrderFine{get; set;}
    
    public DbSet<OrderFinesProgressEntity> OrderFinesProgress {get; set;}

    public DbSet<OrderInfoEntity> OrderInfo {get; set;}

    public DbSet<OrderPaymentProgressEntity> OrderPaymentProgress {get; set;}

    public DbSet<OrderProgressEntity> OrderProgress {get; set;}

    public DbSet<OrderTripProgressEntity> OrderTripProgress {get; set;}

    public DbSet<PriceEntity> Price {get; set;}

    public DbSet<SavedEntity> Saved {get; set;}
}
