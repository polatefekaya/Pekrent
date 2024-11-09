using System;
using CarRental.Domain.DTO.Order.Progress.Trip;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces.Services.Order.Detail.Progress;

public interface IOrderTripProgressService : ICrudService<OrderTripProgressEntity>
{
    Task SetWaitingPickup(SetWaitingPickUpDTO dto);
    Task SetAuthenticated(SetAuthenticatedDTO dto);
    Task SetApproved(SetApprovedPickUpDTO dto);
    Task SetInTrip(SetInTripDTO dto);
    Task SetReturned(SetReturnedDTO dto);
}
