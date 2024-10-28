using System;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces.Services.Listing;

public interface IListingService : ICrudService<ListingEntity>
{
    Task SetBookedCar(int booked);
    Task IncrementBookedCar();
    Task DecrementBookedCar();
    Task IncrementLeftCar();
    Task DecrementLeftCar();
    Task SetAllBooked(bool allBooked);
}
