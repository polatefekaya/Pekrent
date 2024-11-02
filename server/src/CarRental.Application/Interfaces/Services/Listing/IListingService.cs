using System;
using CarRental.Domain.DTO.Listing;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces.Services.Listing;

public interface IListingService : ICrudService<ListingEntity>
{
    Task SetBookedCar(SetBookedCarDTO dto);
    Task IncrementBookedCar(IncrementBookedCarDTO dto);
    Task DecrementBookedCar(DecrementBookedCarDTO dto);
    Task IncrementLeftCar(IncrementLeftCarDTO dto);
    Task DecrementLeftCar(DecrementLeftCarDTO dto);
    Task SetLeftCar(SetLeftCarDTO dto);
    Task SetAllBooked(SetAllBookedDTO dto);
}
